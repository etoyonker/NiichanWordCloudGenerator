using NiichanWordCloudGenerator.Models;
using System.Net.Http.Json;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace NiichanWordCloudGenerator
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;
        private readonly string[] _wordIgnoreList;

        public MainForm()
        {
            InitializeComponent();

            _httpClient = new HttpClient();

            var settingsFolderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NiichanWordCloudGenerator");
            var settingsFilePath = Path.Combine(settingsFolderPath, "settings.json");

            Directory.CreateDirectory(settingsFolderPath);

            var jsonSerializerOptions = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            var settings = new Settings() { WordIgnoreList = ["в", "на"] };

            if (File.Exists(settingsFilePath))
            {
                using var fs = File.Open(settingsFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                settings = JsonSerializer.Deserialize<Settings>(fs, jsonSerializerOptions);
            }
            else
            {
                using var fs = File.Create(settingsFilePath);
                JsonSerializer.Serialize(fs, settings, jsonSerializerOptions);
                fs.Flush();
            }

            _wordIgnoreList = settings?.WordIgnoreList ?? [];
        }

        private async void generateWordCloudButton_Click(object sender, EventArgs e)
        {
            // text field validation
            if (BoardNameTextBoxValidation() || ThreadNumTextBoxValidation())
                return;

            var boardName = mainBoardNameTextBox.Text;
            var threadNum = mainThreadNumTextBox.Text;
            var request = new HttpRequestMessage(
                HttpMethod.Get, $"https://2ch.hk/api/mobile/v2/after/{boardName}/{threadNum}/{threadNum}");

            var rawResponse = await _httpClient.SendAsync(request);

            if (!rawResponse.IsSuccessStatusCode)
            {
                return; // todo: implement error handling
            }

            var response = await rawResponse.Content.ReadFromJsonAsync<NiichanResponse>();

            if (response is null)
            {
                return; // todo: implement error handling
            }

            if (response.error is not null)
            {
                return; // todo: implement error handling
            }

            // main
            var wordsFrequency = GetWordsFrequency(response);
        }

        private Dictionary<string, int> GetWordsFrequency(NiichanResponse response)
        {
            var wordsFrequency = new Dictionary<string, int>();

            foreach (var post in response.posts ?? [])
            {
                if (post.comment is null) continue;

                foreach (var word in post.comment.Split(' '))
                {
                    if (_wordIgnoreList.Contains(word)) continue;

                    wordsFrequency.TryGetValue(word, out var count);
                    wordsFrequency[word] = count + 1;
                }
            }

            return wordsFrequency.OrderByDescending(e => e.Value).ToDictionary();
        }

        private bool BoardNameTextBoxValidation()
        {
            var isStringEmpty = string.IsNullOrWhiteSpace(mainBoardNameTextBox.Text);
            var isStringInvalidBoardName = isStringEmpty || IsStringInvalidBoardName(mainBoardNameTextBox.Text);

            if (isStringEmpty)
                mainErrorProvider.SetError(mainBoardNameTextBox, "Поле обязательно для заполнения");
            else if (isStringInvalidBoardName)
                mainErrorProvider.SetError(mainBoardNameTextBox, "Допускаются только буквы и числа");
            else
                mainErrorProvider.SetError(mainBoardNameTextBox, null);

            return isStringInvalidBoardName;
        }

        private bool ThreadNumTextBoxValidation()
        {
            var isStringEmpty = string.IsNullOrWhiteSpace(mainThreadNumTextBox.Text);
            var isStringInvalidNumber = isStringEmpty || IsStringInvalidNumber(mainThreadNumTextBox.Text);

            if (isStringEmpty)
                mainErrorProvider.SetError(mainThreadNumTextBox, "Поле обязательно для заполнения");
            else if (isStringInvalidNumber)
                mainErrorProvider.SetError(mainThreadNumTextBox, "Допускаются только числа");
            else
                mainErrorProvider.SetError(mainThreadNumTextBox, null);

            return isStringInvalidNumber;
        }

        private static bool IsStringInvalidBoardName(string text) => text.Any(e => !char.IsLetterOrDigit(e));

        private static bool IsStringInvalidNumber(string text) => text.Any(e => !char.IsDigit(e));

        private void mainFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

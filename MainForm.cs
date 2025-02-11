using NiichanWordCloudGenerator.Models;
using System.Net.Http.Json;

namespace NiichanWordCloudGenerator
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;

        public MainForm()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
        }

        private async void generateWordCloudButton_Click(object sender, EventArgs e)
        {
            // text field validation
            if (BoardNameTextBoxValidation() || ThreadNumTextBoxValidation())
                return;

            var boardName = boardNameTextBox.Text;
            var threadNum = threadNumTextBox.Text;
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
                    wordsFrequency.TryGetValue(word, out var count);
                    wordsFrequency[word] = count + 1;
                }
            }

            return wordsFrequency.OrderByDescending(e => e.Value).ToDictionary();
        }

        private bool BoardNameTextBoxValidation()
        {
            var isStringEmpty = string.IsNullOrWhiteSpace(boardNameTextBox.Text);
            var isStringInvalidBoardName = isStringEmpty || IsStringInvalidBoardName(boardNameTextBox.Text);

            if (isStringEmpty)
                errorProvider1.SetError(boardNameTextBox, "Поле обязательно для заполнения");
            else if (isStringInvalidBoardName)
                errorProvider1.SetError(boardNameTextBox, "Допускаются только буквы и числа");
            else
                errorProvider1.SetError(boardNameTextBox, null);

            return isStringInvalidBoardName;
        }

        private bool ThreadNumTextBoxValidation()
        {
            var isStringEmpty = string.IsNullOrWhiteSpace(threadNumTextBox.Text);
            var isStringInvalidNumber = isStringEmpty || IsStringInvalidNumber(threadNumTextBox.Text);

            if (isStringEmpty)
                errorProvider1.SetError(threadNumTextBox, "Поле обязательно для заполнения");
            else if (isStringInvalidNumber)
                errorProvider1.SetError(threadNumTextBox, "Допускаются только числа");
            else
                errorProvider1.SetError(threadNumTextBox, null);

            return isStringInvalidNumber;
        }

        private static bool IsStringInvalidBoardName(string text) => text.Any(e => !char.IsLetterOrDigit(e));

        private static bool IsStringInvalidNumber(string text) => text.Any(e => !char.IsDigit(e));
    }
}

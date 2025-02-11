namespace NiichanWordCloudGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            if (_httpClient != null)
                _httpClient.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainSplitContainer = new SplitContainer();
            mainFlowLayoutPanel = new FlowLayoutPanel();
            mainBoardLabel = new Label();
            mainBoardNameTextBox = new TextBox();
            mainThreadLabel = new Label();
            mainThreadNumTextBox = new TextBox();
            mainGenerateWordCloudButton = new Button();
            mainErrorProvider = new ErrorProvider(components);
            tabControl = new TabControl();
            tabMainPage = new TabPage();
            tabSettingsPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            mainFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainErrorProvider).BeginInit();
            tabControl.SuspendLayout();
            tabMainPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 0);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(mainFlowLayoutPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.BackColor = Color.White;
            mainSplitContainer.Size = new Size(676, 433);
            mainSplitContainer.SplitterDistance = 164;
            mainSplitContainer.TabIndex = 0;
            // 
            // mainFlowLayoutPanel
            // 
            mainFlowLayoutPanel.AutoSize = true;
            mainFlowLayoutPanel.Controls.Add(mainBoardLabel);
            mainFlowLayoutPanel.Controls.Add(mainBoardNameTextBox);
            mainFlowLayoutPanel.Controls.Add(mainThreadLabel);
            mainFlowLayoutPanel.Controls.Add(mainThreadNumTextBox);
            mainFlowLayoutPanel.Controls.Add(mainGenerateWordCloudButton);
            mainFlowLayoutPanel.Dock = DockStyle.Fill;
            mainFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            mainFlowLayoutPanel.Location = new Point(0, 0);
            mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            mainFlowLayoutPanel.Padding = new Padding(8);
            mainFlowLayoutPanel.Size = new Size(164, 433);
            mainFlowLayoutPanel.TabIndex = 0;
            mainFlowLayoutPanel.Paint += mainFlowLayoutPanel_Paint;
            // 
            // mainBoardLabel
            // 
            mainBoardLabel.AutoSize = true;
            mainBoardLabel.Location = new Point(11, 8);
            mainBoardLabel.Name = "mainBoardLabel";
            mainBoardLabel.Size = new Size(40, 15);
            mainBoardLabel.TabIndex = 0;
            mainBoardLabel.Text = "Доска";
            // 
            // mainBoardNameTextBox
            // 
            mainErrorProvider.SetIconPadding(mainBoardNameTextBox, 8);
            mainBoardNameTextBox.Location = new Point(11, 26);
            mainBoardNameTextBox.Name = "mainBoardNameTextBox";
            mainBoardNameTextBox.PlaceholderText = "ja";
            mainBoardNameTextBox.Size = new Size(100, 23);
            mainBoardNameTextBox.TabIndex = 1;
            // 
            // mainThreadLabel
            // 
            mainThreadLabel.AutoSize = true;
            mainThreadLabel.Location = new Point(11, 52);
            mainThreadLabel.Name = "mainThreadLabel";
            mainThreadLabel.Size = new Size(53, 15);
            mainThreadLabel.TabIndex = 2;
            mainThreadLabel.Text = "№ треда";
            // 
            // mainThreadNumTextBox
            // 
            mainErrorProvider.SetIconPadding(mainThreadNumTextBox, 8);
            mainThreadNumTextBox.Location = new Point(11, 70);
            mainThreadNumTextBox.Name = "mainThreadNumTextBox";
            mainThreadNumTextBox.PlaceholderText = "123456";
            mainThreadNumTextBox.Size = new Size(100, 23);
            mainThreadNumTextBox.TabIndex = 3;
            // 
            // mainGenerateWordCloudButton
            // 
            mainGenerateWordCloudButton.Location = new Point(11, 99);
            mainGenerateWordCloudButton.Name = "mainGenerateWordCloudButton";
            mainGenerateWordCloudButton.Size = new Size(100, 25);
            mainGenerateWordCloudButton.TabIndex = 4;
            mainGenerateWordCloudButton.Text = "Сгенерировать облако текста";
            mainGenerateWordCloudButton.UseVisualStyleBackColor = true;
            mainGenerateWordCloudButton.Click += generateWordCloudButton_Click;
            // 
            // mainErrorProvider
            // 
            mainErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            mainErrorProvider.ContainerControl = this;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMainPage);
            tabControl.Controls.Add(tabSettingsPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(684, 461);
            tabControl.TabIndex = 0;
            // 
            // tabMainPage
            // 
            tabMainPage.Controls.Add(mainSplitContainer);
            tabMainPage.Location = new Point(4, 24);
            tabMainPage.Name = "tabMainPage";
            tabMainPage.Size = new Size(676, 433);
            tabMainPage.TabIndex = 0;
            tabMainPage.Text = "Главное";
            tabMainPage.UseVisualStyleBackColor = true;
            // 
            // tabSettingsPage
            // 
            tabSettingsPage.Location = new Point(4, 24);
            tabSettingsPage.Name = "tabSettingsPage";
            tabSettingsPage.Size = new Size(676, 433);
            tabSettingsPage.TabIndex = 0;
            tabSettingsPage.Text = "Настройки";
            tabSettingsPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Niichan word cloud generator";
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            mainFlowLayoutPanel.ResumeLayout(false);
            mainFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainErrorProvider).EndInit();
            tabControl.ResumeLayout(false);
            tabMainPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer mainSplitContainer;
        private FlowLayoutPanel mainFlowLayoutPanel;
        private Label mainBoardLabel;
        private TextBox mainBoardNameTextBox;
        private Label mainThreadLabel;
        private TextBox mainThreadNumTextBox;
        private Button mainGenerateWordCloudButton;
        private ErrorProvider mainErrorProvider;
        private TabControl tabControl;
        private TabPage tabMainPage;
        private TabPage tabSettingsPage;
    }
}

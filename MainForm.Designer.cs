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
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            boardLabel = new Label();
            boardNameTextBox = new TextBox();
            threadLabel = new Label();
            threadNumTextBox = new TextBox();
            generateWordCloudButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(boardLabel);
            flowLayoutPanel1.Controls.Add(boardNameTextBox);
            flowLayoutPanel1.Controls.Add(threadLabel);
            flowLayoutPanel1.Controls.Add(threadNumTextBox);
            flowLayoutPanel1.Controls.Add(generateWordCloudButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(8);
            flowLayoutPanel1.Size = new Size(266, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // boardLabel
            // 
            boardLabel.AutoSize = true;
            boardLabel.Location = new Point(11, 8);
            boardLabel.Name = "boardLabel";
            boardLabel.Size = new Size(40, 15);
            boardLabel.TabIndex = 0;
            boardLabel.Text = "Доска";
            // 
            // boardNameTextBox
            // 
            boardNameTextBox.Location = new Point(11, 26);
            boardNameTextBox.Name = "boardNameTextBox";
            boardNameTextBox.PlaceholderText = "ja";
            boardNameTextBox.Size = new Size(100, 23);
            boardNameTextBox.TabIndex = 1;
            // 
            // threadLabel
            // 
            threadLabel.AutoSize = true;
            threadLabel.Location = new Point(11, 52);
            threadLabel.Name = "threadLabel";
            threadLabel.Size = new Size(53, 15);
            threadLabel.TabIndex = 2;
            threadLabel.Text = "№ треда";
            // 
            // threadNumTextBox
            // 
            threadNumTextBox.Location = new Point(11, 70);
            threadNumTextBox.Name = "threadNumTextBox";
            threadNumTextBox.PlaceholderText = "123456";
            threadNumTextBox.Size = new Size(100, 23);
            threadNumTextBox.TabIndex = 3;
            // 
            // generateWordCloudButton
            // 
            generateWordCloudButton.Location = new Point(11, 99);
            generateWordCloudButton.Name = "generateWordCloudButton";
            generateWordCloudButton.Size = new Size(100, 25);
            generateWordCloudButton.TabIndex = 4;
            generateWordCloudButton.Text = "Сгенерировать облако текста";
            generateWordCloudButton.UseVisualStyleBackColor = true;
            generateWordCloudButton.Click += generateWordCloudButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "Niichan word cloud generator";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label boardLabel;
        private TextBox boardNameTextBox;
        private Label threadLabel;
        private TextBox threadNumTextBox;
        private Button generateWordCloudButton;
        private ErrorProvider errorProvider1;
    }
}

namespace FileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileTreeView = new System.Windows.Forms.TreeView();
            this.copyProgressBar = new System.Windows.Forms.ProgressBar();
            this.directoryButton = new System.Windows.Forms.Button();
            this.directoryNameTextBox = new System.Windows.Forms.TextBox();
            this.chooseDirectoryLabel = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.chooseSavePathButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileTreeView
            // 
            this.fileTreeView.Location = new System.Drawing.Point(13, 13);
            this.fileTreeView.Name = "fileTreeView";
            this.fileTreeView.Size = new System.Drawing.Size(411, 475);
            this.fileTreeView.TabIndex = 0;
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.Location = new System.Drawing.Point(13, 495);
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(655, 23);
            this.copyProgressBar.TabIndex = 1;
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(646, 69);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(22, 19);
            this.directoryButton.TabIndex = 2;
            this.directoryButton.Text = "...";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // directoryNameTextBox
            // 
            this.directoryNameTextBox.Location = new System.Drawing.Point(431, 67);
            this.directoryNameTextBox.Name = "directoryNameTextBox";
            this.directoryNameTextBox.ReadOnly = true;
            this.directoryNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.directoryNameTextBox.TabIndex = 3;
            // 
            // chooseDirectoryLabel
            // 
            this.chooseDirectoryLabel.AutoSize = true;
            this.chooseDirectoryLabel.Location = new System.Drawing.Point(431, 48);
            this.chooseDirectoryLabel.Name = "chooseDirectoryLabel";
            this.chooseDirectoryLabel.Size = new System.Drawing.Size(92, 13);
            this.chooseDirectoryLabel.TabIndex = 4;
            this.chooseDirectoryLabel.Text = "Choose directory :";
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Location = new System.Drawing.Point(431, 121);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(49, 13);
            this.savePathLabel.TabIndex = 5;
            this.savePathLabel.Text = "Save in :";
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(431, 137);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.ReadOnly = true;
            this.savePathTextBox.Size = new System.Drawing.Size(209, 20);
            this.savePathTextBox.TabIndex = 6;
            // 
            // chooseSavePathButton
            // 
            this.chooseSavePathButton.Location = new System.Drawing.Point(646, 138);
            this.chooseSavePathButton.Name = "chooseSavePathButton";
            this.chooseSavePathButton.Size = new System.Drawing.Size(22, 19);
            this.chooseSavePathButton.TabIndex = 7;
            this.chooseSavePathButton.Text = "...";
            this.chooseSavePathButton.UseVisualStyleBackColor = true;
            this.chooseSavePathButton.Click += new System.EventHandler(this.chooseSavePathButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(478, 197);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(144, 46);
            this.writeButton.TabIndex = 8;
            this.writeButton.Text = "Write XML";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 528);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.chooseSavePathButton);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.chooseDirectoryLabel);
            this.Controls.Add(this.directoryNameTextBox);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.copyProgressBar);
            this.Controls.Add(this.fileTreeView);
            this.Name = "MainForm";
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView fileTreeView;
        private System.Windows.Forms.ProgressBar copyProgressBar;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.TextBox directoryNameTextBox;
        private System.Windows.Forms.Label chooseDirectoryLabel;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.Button chooseSavePathButton;
        private System.Windows.Forms.Button writeButton;
    }
}


namespace Cryp10.FileLock
{
    partial class Form1
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
            this.openFilesToEncryptDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFilesToEncryptButton = new System.Windows.Forms.Button();
            this.selectEncryptionFilesButton = new System.Windows.Forms.Button();
            this.selectedFilesToEncryptListBox = new System.Windows.Forms.ListBox();
            this.selectedFilesForEncryptionListBox = new System.Windows.Forms.ListBox();
            this.encryptFilesButton = new System.Windows.Forms.Button();
            this.openFilesForEncryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFilesToEncryptDialog
            // 
            this.openFilesToEncryptDialog.FileName = "openFileDialog1";
            this.openFilesToEncryptDialog.Multiselect = true;
            // 
            // selectFilesToEncryptButton
            // 
            this.selectFilesToEncryptButton.Location = new System.Drawing.Point(66, 113);
            this.selectFilesToEncryptButton.Name = "selectFilesToEncryptButton";
            this.selectFilesToEncryptButton.Size = new System.Drawing.Size(148, 23);
            this.selectFilesToEncryptButton.TabIndex = 0;
            this.selectFilesToEncryptButton.Text = "Select Files To Encrypt";
            this.selectFilesToEncryptButton.UseVisualStyleBackColor = true;
            this.selectFilesToEncryptButton.Click += new System.EventHandler(this.selectFilesToEncryptButton_Click);
            // 
            // selectEncryptionFilesButton
            // 
            this.selectEncryptionFilesButton.Location = new System.Drawing.Point(329, 113);
            this.selectEncryptionFilesButton.Name = "selectEncryptionFilesButton";
            this.selectEncryptionFilesButton.Size = new System.Drawing.Size(148, 23);
            this.selectEncryptionFilesButton.TabIndex = 1;
            this.selectEncryptionFilesButton.Text = "Select Encryption Files";
            this.selectEncryptionFilesButton.UseVisualStyleBackColor = true;
            this.selectEncryptionFilesButton.Click += new System.EventHandler(this.selectEncryptionFilesButton_Click);
            // 
            // selectedFilesToEncryptListBox
            // 
            this.selectedFilesToEncryptListBox.FormattingEnabled = true;
            this.selectedFilesToEncryptListBox.Location = new System.Drawing.Point(12, 12);
            this.selectedFilesToEncryptListBox.Name = "selectedFilesToEncryptListBox";
            this.selectedFilesToEncryptListBox.Size = new System.Drawing.Size(257, 95);
            this.selectedFilesToEncryptListBox.TabIndex = 2;
            // 
            // selectedFilesForEncryptionListBox
            // 
            this.selectedFilesForEncryptionListBox.FormattingEnabled = true;
            this.selectedFilesForEncryptionListBox.Location = new System.Drawing.Point(275, 12);
            this.selectedFilesForEncryptionListBox.Name = "selectedFilesForEncryptionListBox";
            this.selectedFilesForEncryptionListBox.Size = new System.Drawing.Size(257, 95);
            this.selectedFilesForEncryptionListBox.TabIndex = 3;
            // 
            // encryptFilesButton
            // 
            this.encryptFilesButton.Location = new System.Drawing.Point(198, 313);
            this.encryptFilesButton.Name = "encryptFilesButton";
            this.encryptFilesButton.Size = new System.Drawing.Size(146, 51);
            this.encryptFilesButton.TabIndex = 4;
            this.encryptFilesButton.Text = "Encrypt Files";
            this.encryptFilesButton.UseVisualStyleBackColor = true;
            this.encryptFilesButton.Click += new System.EventHandler(this.encryptFilesButton_Click);
            // 
            // openFilesForEncryptionDialog
            // 
            this.openFilesForEncryptionDialog.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 152);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(478, 21);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 179);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(478, 55);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(12, 240);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(478, 58);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 376);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.encryptFilesButton);
            this.Controls.Add(this.selectedFilesForEncryptionListBox);
            this.Controls.Add(this.selectedFilesToEncryptListBox);
            this.Controls.Add(this.selectEncryptionFilesButton);
            this.Controls.Add(this.selectFilesToEncryptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFilesToEncryptDialog;
        private System.Windows.Forms.Button selectFilesToEncryptButton;
        private System.Windows.Forms.Button selectEncryptionFilesButton;
        private System.Windows.Forms.ListBox selectedFilesToEncryptListBox;
        private System.Windows.Forms.ListBox selectedFilesForEncryptionListBox;
        private System.Windows.Forms.Button encryptFilesButton;
        private System.Windows.Forms.OpenFileDialog openFilesForEncryptionDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}


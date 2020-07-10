namespace Cryp10
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
            this.fileSelector = new System.Windows.Forms.OpenFileDialog();
            this.selectFileToEncryptButton = new System.Windows.Forms.Button();
            this.selectedFilesToEncryptListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fileSelector
            // 
            this.fileSelector.FileName = "openFileDialog1";
            this.fileSelector.Multiselect = true;
            // 
            // selectFileToEncryptButton
            // 
            this.selectFileToEncryptButton.Location = new System.Drawing.Point(0, 0);
            this.selectFileToEncryptButton.Name = "selectFileToEncryptButton";
            this.selectFileToEncryptButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileToEncryptButton.TabIndex = 0;
            this.selectFileToEncryptButton.Text = "button1";
            this.selectFileToEncryptButton.UseVisualStyleBackColor = true;
            // 
            // selectedFilesToEncryptListBox
            // 
            this.selectedFilesToEncryptListBox.FormattingEnabled = true;
            this.selectedFilesToEncryptListBox.Location = new System.Drawing.Point(0, 41);
            this.selectedFilesToEncryptListBox.Name = "selectedFilesToEncryptListBox";
            this.selectedFilesToEncryptListBox.Size = new System.Drawing.Size(120, 95);
            this.selectedFilesToEncryptListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedFilesToEncryptListBox);
            this.Controls.Add(this.selectFileToEncryptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileSelector;
        private System.Windows.Forms.Button selectFileToEncryptButton;
        private System.Windows.Forms.ListBox selectedFilesToEncryptListBox;
    }
}


namespace EncrypterKaoti
{
    partial class encryptForm
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
            this.EncryptFileDir = new System.Windows.Forms.TextBox();
            this.SFileToEncryptButton = new System.Windows.Forms.Button();
            this.LabelPassDecrypt = new System.Windows.Forms.Label();
            this.Pass4Decryption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IntPassLenght = new System.Windows.Forms.NumericUpDown();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.genPassBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IntPassLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptFileDir
            // 
            this.EncryptFileDir.BackColor = System.Drawing.Color.Black;
            this.EncryptFileDir.ForeColor = System.Drawing.Color.Cyan;
            this.EncryptFileDir.Location = new System.Drawing.Point(145, 37);
            this.EncryptFileDir.Name = "EncryptFileDir";
            this.EncryptFileDir.Size = new System.Drawing.Size(335, 20);
            this.EncryptFileDir.TabIndex = 3;
            // 
            // SFileToEncryptButton
            // 
            this.SFileToEncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFileToEncryptButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFileToEncryptButton.ForeColor = System.Drawing.Color.Red;
            this.SFileToEncryptButton.Location = new System.Drawing.Point(15, 21);
            this.SFileToEncryptButton.Name = "SFileToEncryptButton";
            this.SFileToEncryptButton.Size = new System.Drawing.Size(124, 36);
            this.SFileToEncryptButton.TabIndex = 2;
            this.SFileToEncryptButton.Text = "Select File To Encrypt:";
            this.SFileToEncryptButton.UseVisualStyleBackColor = true;
            this.SFileToEncryptButton.Click += new System.EventHandler(this.SFileToEncryptButton_Click);
            // 
            // LabelPassDecrypt
            // 
            this.LabelPassDecrypt.AutoSize = true;
            this.LabelPassDecrypt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassDecrypt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelPassDecrypt.Location = new System.Drawing.Point(143, 99);
            this.LabelPassDecrypt.Name = "LabelPassDecrypt";
            this.LabelPassDecrypt.Size = new System.Drawing.Size(124, 11);
            this.LabelPassDecrypt.TabIndex = 13;
            this.LabelPassDecrypt.Text = "Password Encrypt:";
            // 
            // Pass4Decryption
            // 
            this.Pass4Decryption.BackColor = System.Drawing.Color.Black;
            this.Pass4Decryption.ForeColor = System.Drawing.Color.Cyan;
            this.Pass4Decryption.Location = new System.Drawing.Point(275, 94);
            this.Pass4Decryption.Name = "Pass4Decryption";
            this.Pass4Decryption.Size = new System.Drawing.Size(205, 20);
            this.Pass4Decryption.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(143, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pass Lenght";
            // 
            // IntPassLenght
            // 
            this.IntPassLenght.BackColor = System.Drawing.Color.Black;
            this.IntPassLenght.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntPassLenght.Cursor = System.Windows.Forms.Cursors.Default;
            this.IntPassLenght.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.IntPassLenght.Location = new System.Drawing.Point(273, 68);
            this.IntPassLenght.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IntPassLenght.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IntPassLenght.Name = "IntPassLenght";
            this.IntPassLenght.Size = new System.Drawing.Size(37, 16);
            this.IntPassLenght.TabIndex = 15;
            this.IntPassLenght.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(521, 21);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(71, 99);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.ForeColor = System.Drawing.Color.Red;
            this.EncryptButton.Location = new System.Drawing.Point(15, 126);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(124, 37);
            this.EncryptButton.TabIndex = 18;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // genPassBtn
            // 
            this.genPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genPassBtn.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genPassBtn.ForeColor = System.Drawing.Color.Red;
            this.genPassBtn.Location = new System.Drawing.Point(15, 72);
            this.genPassBtn.Name = "genPassBtn";
            this.genPassBtn.Size = new System.Drawing.Size(124, 48);
            this.genPassBtn.TabIndex = 22;
            this.genPassBtn.TabStop = false;
            this.genPassBtn.Text = "Generate";
            this.genPassBtn.UseVisualStyleBackColor = true;
            this.genPassBtn.Click += new System.EventHandler(this.genPassBtn_Click);
            // 
            // encryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(607, 180);
            this.Controls.Add(this.genPassBtn);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LabelPassDecrypt);
            this.Controls.Add(this.Pass4Decryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntPassLenght);
            this.Controls.Add(this.EncryptFileDir);
            this.Controls.Add(this.SFileToEncryptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "encryptForm";
            this.Text = "encryptForm";
            ((System.ComponentModel.ISupportInitialize)(this.IntPassLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EncryptFileDir;
        private System.Windows.Forms.Button SFileToEncryptButton;
        private System.Windows.Forms.Label LabelPassDecrypt;
        private System.Windows.Forms.TextBox Pass4Decryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IntPassLenght;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button genPassBtn;
    }
}
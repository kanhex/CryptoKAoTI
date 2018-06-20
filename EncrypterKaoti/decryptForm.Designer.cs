namespace EncrypterKaoti
{
    partial class decryptForm
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PassFileRBTN = new System.Windows.Forms.RadioButton();
            this.PassTextRBTN = new System.Windows.Forms.RadioButton();
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
            this.SFileToEncryptButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.SFileToEncryptButton.Location = new System.Drawing.Point(15, 21);
            this.SFileToEncryptButton.Name = "SFileToEncryptButton";
            this.SFileToEncryptButton.Size = new System.Drawing.Size(124, 36);
            this.SFileToEncryptButton.TabIndex = 2;
            this.SFileToEncryptButton.Text = "Select File To Decrypt:";
            this.SFileToEncryptButton.UseVisualStyleBackColor = true;
            this.SFileToEncryptButton.Click += new System.EventHandler(this.SFileToEncryptButton_Click);
            // 
            // LabelPassDecrypt
            // 
            this.LabelPassDecrypt.AutoSize = true;
            this.LabelPassDecrypt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassDecrypt.ForeColor = System.Drawing.Color.SpringGreen;
            this.LabelPassDecrypt.Location = new System.Drawing.Point(143, 106);
            this.LabelPassDecrypt.Name = "LabelPassDecrypt";
            this.LabelPassDecrypt.Size = new System.Drawing.Size(103, 11);
            this.LabelPassDecrypt.TabIndex = 13;
            this.LabelPassDecrypt.Text = "Write Password";
            this.LabelPassDecrypt.Visible = false;
            // 
            // Pass4Decryption
            // 
            this.Pass4Decryption.BackColor = System.Drawing.Color.Black;
            this.Pass4Decryption.ForeColor = System.Drawing.Color.Cyan;
            this.Pass4Decryption.Location = new System.Drawing.Point(354, 70);
            this.Pass4Decryption.Name = "Pass4Decryption";
            this.Pass4Decryption.Size = new System.Drawing.Size(270, 20);
            this.Pass4Decryption.TabIndex = 14;
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.ClearButton.Location = new System.Drawing.Point(521, 21);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(71, 36);
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
            this.EncryptButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.EncryptButton.Location = new System.Drawing.Point(15, 160);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(124, 37);
            this.EncryptButton.TabIndex = 18;
            this.EncryptButton.Text = "Decrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(252, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(145, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Select File To Decrypt:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassFileRBTN
            // 
            this.PassFileRBTN.AutoSize = true;
            this.PassFileRBTN.Checked = true;
            this.PassFileRBTN.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.PassFileRBTN.Location = new System.Drawing.Point(15, 75);
            this.PassFileRBTN.Name = "PassFileRBTN";
            this.PassFileRBTN.Size = new System.Drawing.Size(90, 17);
            this.PassFileRBTN.TabIndex = 22;
            this.PassFileRBTN.TabStop = true;
            this.PassFileRBTN.Text = "Password File";
            this.PassFileRBTN.UseVisualStyleBackColor = true;
            this.PassFileRBTN.CheckedChanged += new System.EventHandler(this.PassFileRBTN_CheckedChanged);
            // 
            // PassTextRBTN
            // 
            this.PassTextRBTN.AutoSize = true;
            this.PassTextRBTN.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.PassTextRBTN.Location = new System.Drawing.Point(15, 98);
            this.PassTextRBTN.Name = "PassTextRBTN";
            this.PassTextRBTN.Size = new System.Drawing.Size(95, 17);
            this.PassTextRBTN.TabIndex = 21;
            this.PassTextRBTN.Text = "Text Password";
            this.PassTextRBTN.UseVisualStyleBackColor = true;
            this.PassTextRBTN.CheckedChanged += new System.EventHandler(this.PassTextRBTN_CheckedChanged);
            // 
            // decryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(653, 209);
            this.Controls.Add(this.PassFileRBTN);
            this.Controls.Add(this.PassTextRBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LabelPassDecrypt);
            this.Controls.Add(this.Pass4Decryption);
            this.Controls.Add(this.EncryptFileDir);
            this.Controls.Add(this.SFileToEncryptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "decryptForm";
            this.Text = "Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EncryptFileDir;
        private System.Windows.Forms.Button SFileToEncryptButton;
        private System.Windows.Forms.Label LabelPassDecrypt;
        private System.Windows.Forms.TextBox Pass4Decryption;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton PassFileRBTN;
        private System.Windows.Forms.RadioButton PassTextRBTN;
    }
}
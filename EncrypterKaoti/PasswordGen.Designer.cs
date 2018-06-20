namespace EncrypterKaoti
{
    partial class PasswordGen
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
            this.PassTextRBTN = new System.Windows.Forms.RadioButton();
            this.PassFileRBTN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GenLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.genPassBtn = new System.Windows.Forms.Button();
            this.LabelPassDecrypt = new System.Windows.Forms.Label();
            this.Pass4Decryption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IntPassLenght = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntPassLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // PassTextRBTN
            // 
            this.PassTextRBTN.AutoSize = true;
            this.PassTextRBTN.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.PassTextRBTN.Location = new System.Drawing.Point(288, 90);
            this.PassTextRBTN.Name = "PassTextRBTN";
            this.PassTextRBTN.Size = new System.Drawing.Size(95, 17);
            this.PassTextRBTN.TabIndex = 0;
            this.PassTextRBTN.Text = "Text Password";
            this.PassTextRBTN.UseVisualStyleBackColor = true;
            this.PassTextRBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PassFileRBTN
            // 
            this.PassFileRBTN.AutoSize = true;
            this.PassFileRBTN.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.PassFileRBTN.Location = new System.Drawing.Point(288, 67);
            this.PassFileRBTN.Name = "PassFileRBTN";
            this.PassFileRBTN.Size = new System.Drawing.Size(157, 17);
            this.PassFileRBTN.TabIndex = 1;
            this.PassFileRBTN.Text = "Password File(More Secure)";
            this.PassFileRBTN.UseVisualStyleBackColor = true;
            this.PassFileRBTN.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.GenLbl);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password File";
            this.groupBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.Yellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "256",
            "128"});
            this.listBox1.Location = new System.Drawing.Point(12, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(38, 38);
            this.listBox1.TabIndex = 32;
            // 
            // GenLbl
            // 
            this.GenLbl.AutoSize = true;
            this.GenLbl.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.GenLbl.Location = new System.Drawing.Point(10, 157);
            this.GenLbl.Name = "GenLbl";
            this.GenLbl.Size = new System.Drawing.Size(0, 12);
            this.GenLbl.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.BlueViolet;
            this.button2.Location = new System.Drawing.Point(80, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 48);
            this.button2.TabIndex = 30;
            this.button2.TabStop = false;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pass Lenght in Bytes:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.genPassBtn);
            this.groupBox2.Controls.Add(this.LabelPassDecrypt);
            this.groupBox2.Controls.Add(this.Pass4Decryption);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IntPassLenght);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Location = new System.Drawing.Point(451, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 295);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Password";
            this.groupBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(6, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 26);
            this.button1.TabIndex = 28;
            this.button1.TabStop = false;
            this.button1.Text = "Copy PassWord";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // genPassBtn
            // 
            this.genPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genPassBtn.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genPassBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.genPassBtn.Location = new System.Drawing.Point(74, 24);
            this.genPassBtn.Name = "genPassBtn";
            this.genPassBtn.Size = new System.Drawing.Size(124, 48);
            this.genPassBtn.TabIndex = 27;
            this.genPassBtn.TabStop = false;
            this.genPassBtn.Text = "Generate";
            this.genPassBtn.UseVisualStyleBackColor = true;
            this.genPassBtn.Click += new System.EventHandler(this.genPassBtn_Click);
            // 
            // LabelPassDecrypt
            // 
            this.LabelPassDecrypt.AutoSize = true;
            this.LabelPassDecrypt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassDecrypt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelPassDecrypt.Location = new System.Drawing.Point(2, 110);
            this.LabelPassDecrypt.Name = "LabelPassDecrypt";
            this.LabelPassDecrypt.Size = new System.Drawing.Size(124, 11);
            this.LabelPassDecrypt.TabIndex = 23;
            this.LabelPassDecrypt.Text = "Password Encrypt:";
            // 
            // Pass4Decryption
            // 
            this.Pass4Decryption.BackColor = System.Drawing.Color.Black;
            this.Pass4Decryption.ForeColor = System.Drawing.Color.BlueViolet;
            this.Pass4Decryption.Location = new System.Drawing.Point(6, 124);
            this.Pass4Decryption.Multiline = true;
            this.Pass4Decryption.Name = "Pass4Decryption";
            this.Pass4Decryption.ReadOnly = true;
            this.Pass4Decryption.Size = new System.Drawing.Size(258, 136);
            this.Pass4Decryption.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pass Lenght";
            // 
            // IntPassLenght
            // 
            this.IntPassLenght.BackColor = System.Drawing.Color.Black;
            this.IntPassLenght.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntPassLenght.Cursor = System.Windows.Forms.Cursors.Default;
            this.IntPassLenght.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.IntPassLenght.Location = new System.Drawing.Point(134, 78);
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
            this.IntPassLenght.Size = new System.Drawing.Size(37, 21);
            this.IntPassLenght.TabIndex = 25;
            this.IntPassLenght.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.saveBtn.Location = new System.Drawing.Point(304, 253);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 48);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.TabStop = false;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // PasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(732, 319);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PassFileRBTN);
            this.Controls.Add(this.PassTextRBTN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PasswordGen";
            this.Text = "PasswordGen";
            this.Load += new System.EventHandler(this.PasswordGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntPassLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PassTextRBTN;
        private System.Windows.Forms.RadioButton PassFileRBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button genPassBtn;
        private System.Windows.Forms.Label LabelPassDecrypt;
        private System.Windows.Forms.TextBox Pass4Decryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IntPassLenght;
        private System.Windows.Forms.Label GenLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}
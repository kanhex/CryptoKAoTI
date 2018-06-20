namespace EncrypterKaoti
{
    partial class dialog
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
            this.stopBtn = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.FILE = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encryptProgress = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopBtn
            // 
            this.stopBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.Red;
            this.stopBtn.Location = new System.Drawing.Point(834, 90);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(159, 26);
            this.stopBtn.TabIndex = 19;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.Aquamarine;
            this.Progress.ForeColor = System.Drawing.Color.Aquamarine;
            this.Progress.Location = new System.Drawing.Point(16, 58);
            this.Progress.Name = "Progress";
            this.Progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Progress.Size = new System.Drawing.Size(812, 26);
            this.Progress.Step = 1;
            this.Progress.TabIndex = 22;
            // 
            // FILE
            // 
            this.FILE.AutoSize = true;
            this.FILE.Font = new System.Drawing.Font("Proxy 9", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FILE.ForeColor = System.Drawing.Color.Red;
            this.FILE.Location = new System.Drawing.Point(12, 12);
            this.FILE.Name = "FILE";
            this.FILE.Size = new System.Drawing.Size(65, 19);
            this.FILE.TabIndex = 23;
            this.FILE.Text = "PATH: ";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Proxy 9", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.Red;
            this.statusLbl.Location = new System.Drawing.Point(12, 31);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLbl.Size = new System.Drawing.Size(0, 22);
            this.statusLbl.TabIndex = 24;
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLbl.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(12, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(981, 137);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Encrypting...";
            // 
            // encryptProgress
            // 
            this.encryptProgress.BackColor = System.Drawing.Color.Aquamarine;
            this.encryptProgress.ForeColor = System.Drawing.Color.Aquamarine;
            this.encryptProgress.Location = new System.Drawing.Point(16, 90);
            this.encryptProgress.Name = "encryptProgress";
            this.encryptProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.encryptProgress.Size = new System.Drawing.Size(812, 26);
            this.encryptProgress.Step = 1;
            this.encryptProgress.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(834, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(972, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 29;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.stopBtn;
            this.ClientSize = new System.Drawing.Size(1005, 271);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.encryptProgress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.FILE);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.stopBtn);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dialog";
            this.Text = "dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopBtn;
        public System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label FILE;
        private System.Windows.Forms.Label statusLbl;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ProgressBar encryptProgress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
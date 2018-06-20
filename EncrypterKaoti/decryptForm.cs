using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace EncrypterKaoti
{
    public partial class decryptForm : Form
    {
        bool isfile = true;
        String pass = "";
        string filename;
        public OpenFileDialog SFTD = new OpenFileDialog();

        public decryptForm()
        {
            InitializeComponent();
        }



        private void ClearButton_Click(object sender, EventArgs e)
        {
            EncryptFileDir.Text = null;
            Pass4Decryption.Text = null;
            pass = null;
        }

        private void SFileToEncryptButton_Click(object sender, EventArgs e)
        {

            SFTD.Title = "Please Open File To Decrypt";
            SFTD.Filter = "Encrypted Files *.K4L0ckED|*.K4L0ckED";
            if (SFTD.ShowDialog() == DialogResult.OK)
            {
                EncryptFileDir.Text = SFTD.FileName;
            }
        }
        

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            pass = Pass4Decryption.Text;
            filename = EncryptFileDir.Text;
            if (filename != "" && pass != "")
            {

                dialogD dial = new dialogD(filename, pass, isfile);
                dial.Show();
            }
            else
            {
                MessageBox.Show(""
                    + ((filename == "") ? "Please select a file to Decrypt. \n" : "")
                    + ((pass == "") ? "Please Write the password or select a Password file. \n" : "")
                    );
            }




        }

        private void PassFileRBTN_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            Pass4Decryption.Visible = true;
            LabelPassDecrypt.Visible = false;
            textBox1.Visible = false;
            isfile = true;
            pass = Pass4Decryption.Text;
        }

        private void PassTextRBTN_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            Pass4Decryption.Visible = false;
            LabelPassDecrypt.Visible = true;
            textBox1.Visible = true;
            isfile = false;
            pass = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SFTD.Title = "Please Open Key File";
            SFTD.Filter = "XKey Files *.Xk3y|*.Xk3y";
            if (SFTD.ShowDialog() == DialogResult.OK)
            {
                Pass4Decryption.Text = SFTD.FileName;
            }
        }
    }
}

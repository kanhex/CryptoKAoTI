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
    public partial class encryptForm : Form
    {
        String pass;
        string filename;
        public OpenFileDialog SFTE = new OpenFileDialog();
        public OpenFileDialog SFTD = new OpenFileDialog();

        public encryptForm()
        {
            InitializeComponent();
        }

        private void genPassBtn_Click(object sender, EventArgs e)
        {
            pass = Encrypt.CreatePassword(Convert.ToInt32(IntPassLenght.Value));
            Pass4Decryption.Text = pass;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EncryptFileDir.Text = null;
            Pass4Decryption.Text = null;
            pass = null;
        }

        private void SFileToEncryptButton_Click(object sender, EventArgs e)
        {
            SFTE.Title = "Please Open File To Encrypt";
            if (SFTE.ShowDialog() == DialogResult.OK)
            {
                EncryptFileDir.Text = SFTE.FileName;
            }
        }
        

        private void EncryptButton_Click(object sender, EventArgs e)
        {

            filename = EncryptFileDir.Text;
            dialog dial = new dialog(filename, pass);
            dial.Show();



        }


        
    }
}

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
        String pass;
        string filename;
        public OpenFileDialog SFTE = new OpenFileDialog();
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
            dialogD dial = new dialogD(filename, pass);
            dial.Show();



        }


        
    }
}

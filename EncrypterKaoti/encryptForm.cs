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
         bool isfile;
        string filename;
        public OpenFileDialog SFTE = new OpenFileDialog();
        PasswordGen passG ;


        public encryptForm()
        {
            InitializeComponent();
        }

        private void genPassBtn_Click(object sender, EventArgs e)
        {

            passG = new PasswordGen(EncryptFileDir.Text);
            passG.ShowInTaskbar = false;
            passG.ShowDialog();
            
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EncryptFileDir.Text = null;
            pass = null;
            pass = null;
        }

        private void SFileToEncryptButton_Click(object sender, EventArgs e)
        {
            SFTE.Title = "Please Open File To Encrypt";
            if (SFTE.ShowDialog() == DialogResult.OK)
            {
                EncryptFileDir.Text = SFTE.FileName;
                genPassBtn.Visible = true;
            }
        }
        

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            filename = EncryptFileDir.Text;
            pass = passG.pass;
            isfile = passG.isFile;
            if (filename != "" && pass != "")
            {
                
                filename = EncryptFileDir.Text;
                dialog dial = new dialog(filename, pass, isfile);
                dial.Show();
            }
            else{
                MessageBox.Show(""
                    + ((filename == "") ? "Please select a file to Decrypt. \n" : "")
                    + ((pass == "") ? "Please Generate a Password. \n" : "")
                    );
            }


        }




       


    }
}

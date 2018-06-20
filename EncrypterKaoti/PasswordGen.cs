using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace EncrypterKaoti
{
 
    public partial class PasswordGen : Form
    {
        public string pass = "";
        public bool isFile = true;
        string fileEnc;
        public PasswordGen(string file)
        {
            InitializeComponent();
            fileEnc = file;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (PassTextRBTN.Checked == true)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (PassFileRBTN.Checked == true)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string fnameE = System.IO.Path.GetFileName(fileEnc);
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/keys/");
                string fName = Directory.GetCurrentDirectory() + "/keys/Key_" + fnameE+"_"+getRandomFileName() + ".Xk3y";
                var itm = listBox1.GetItemText(listBox1.SelectedItem);
                File.WriteAllBytes(fName, Encrypt.generateKeyBytes(Convert.ToInt32(itm)));
                GenLbl.Text = "Generated! \n" + fName;

                pass = fName;
                isFile = true;
                saveBtn.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static string getRandomFileName()
        {
            string text = "";
            string text2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!=&&aЬcdёfgнїjкlмпоpqґ$тцvшжуzABCDЁFGHЇJКLMИОPФЯ$TЦVЩЖУZ";
            Random random = new Random();
            int num = random.Next(4, 10);
            while (Math.Max(Interlocked.Decrement(ref num), checked(num + 1)) > 0)
            {
                text += Convert.ToString(text2[random.Next(text2.Length)]);
            }
            return text;
        }

        private void genPassBtn_Click(object sender, EventArgs e)
        {
            pass = Encrypt.CreatePassword(Convert.ToInt32(IntPassLenght.Value));
            Pass4Decryption.Text = pass;
            isFile = false;
            saveBtn.Enabled = true;
        }

        private void PasswordGen_Load(object sender, EventArgs e)
        {
            
            listBox1.SelectedIndex = 0;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

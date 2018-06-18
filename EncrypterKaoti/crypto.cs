using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EncrypterKaoti
{
    public partial class crypto : Form
    {
        public crypto()
        {
            InitializeComponent();
            
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            encryptForm encryptF = new encryptForm();
            encryptF.Show();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            decryptForm encryptF = new decryptForm();
            encryptF.Show();
        }
    }
}

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
    public partial class dialog : Form
    {
        String pass;
        string filename;
        ThreadStart encryptThreadStart;
        Thread encryptThread;
        bool isfile;


        public dialog(string pathV, string passV, bool isFileArg)
        {
            InitializeComponent();
            FILE.Text = "FILE: " + pathV + (isFileArg?"  |  PassWord File:"+passV:"");

            pass = passV;
            filename = pathV;

            isfile = isFileArg;




        }

        delegate void RefreshProgressDelegate(int percent);
        delegate void RefreshProgress2Delegate(int percent);
        delegate void RefreshTextDelegate(string text);
        delegate void RefreshDataDelegate(string text);
        delegate void ClearDelegate();


        public void RefreshProgress(int value)
        {
            if (this == null) return;
            Progress.Value = (int)value;
        }
        public void RefreshProgress2(int value)
        {
            if (this == null) return;
            encryptProgress.Value = (int)value;
        }
        public void RefreshText(string Text)
        {
            if (this == null) return;
            textBox1.AppendText(Text);
        }
        public void RefreshData(string Text)
        {
            if (this == null) return;
            statusLbl.Text = Text;
        }
        public void ClearData()
        {
            if (this == null) return;
            statusLbl.Text = "";
        }

        void EncryptProcess()
        {

            try
            {
                if (File.Exists(filename))
                {
                    byte[] passwordBytes;
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 5);
                    if (isfile)
                    {
                        this.Invoke(new RefreshTextDelegate(RefreshText), "\n Opening Password File. \n");
                        passwordBytes = File.ReadAllBytes(pass);
                        this.Invoke(new RefreshTextDelegate(RefreshText), "\n Password encoded into a sequence of bytes. \n");
                    }
                    else
                    {
                        
                        passwordBytes = Encoding.UTF8.GetBytes(pass);
                        this.Invoke(new RefreshTextDelegate(RefreshText), "\n Password encoded into a sequence of bytes. \n");
                    }
                    
                    
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 7);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Starting Encryption with a chunk size of 100000. \n");
                    encryptFile(500000, filename, passwordBytes);

                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 100);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Finished! \n");
                    this.Invoke(new RefreshTextDelegate(RefreshData), "Finished!");
                    MessageBox.Show("Encrypted");
                    encryptThread.Abort();
                }
                else
                {
                    encryptThread.Abort();

                }
        }
            catch (ThreadAbortException ex)
            {
                this.Invoke(new RefreshTextDelegate(RefreshText), "Process aborted :O!  \n");
            }

        }

        


        

        private void stopBtn_Click(object sender, EventArgs e)
        {
            encryptThread.Abort();
            this.Invoke(new ClearDelegate(ClearData));
            this.Invoke(new RefreshTextDelegate(RefreshData), "Stopped. Process aborted :O!!! ");
            if (File.Exists(filename + ".K4L0ckED") && File.Exists(filename))
            {
                this.Invoke(new RefreshTextDelegate(RefreshData), "Deleting incomplete Encrypted File.");
                System.IO.File.Delete(filename + ".K4L0ckED");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encryptThreadStart = new ThreadStart(EncryptProcess);
            encryptThread = new Thread(encryptThreadStart);
            encryptThread.Start();
            encryptThread.IsBackground = true;
        }

        private void encryptFile(int chunkSize, string path, byte[] passwordBytes)
        {
            File.Create(path + ".K4L0ckED").Dispose();
            this.Invoke(new RefreshTextDelegate(RefreshText), "Created .K4L0ckED file. \n");
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 10);

            byte[] buffer = new byte[chunkSize];
            List<byte> extraBuffer = new List<byte>();

            using (Stream input = File.OpenRead(path))
            {
                int index = 0;
                while (input.Position < input.Length)
                {
                    using (var output = new FileStream(path + ".K4L0ckED", FileMode.Append))
                    {
                        int chunkBytesRead = 0;
                        while (chunkBytesRead < chunkSize)
                        {
                            int bytesRead = input.Read(buffer, chunkBytesRead, chunkSize - chunkBytesRead);

                            if (bytesRead == 0)
                            {
                                break;
                            }
                            //long total: 2249999850 File: 100%
                            //     index:   660         File:    64.551.000     
                            //               x1.000.000




                            chunkBytesRead += bytesRead;
                        }

                        

                        output.Write(encriptArray(buffer, passwordBytes), 0, chunkBytesRead);

                    }
                    //zpн*f&jc/uj$M3p=Ohw0ЩЩhґx1lL*
                    long ind = index;
                    long longi = input.Length;
                    var total = (5000000 * 7 * ind / longi).ToString();
                    var total10 = (5000000 * 10 * ind / longi).ToString();

                    this.Invoke(new RefreshTextDelegate(RefreshData), "Longitud total: "+input.Length + "      |   Status: Encrypting.." +"      |    percent: " + total10 +  "   |   Index: " + ind);
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), Convert.ToInt32(total));
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Encrypting... " + Convert.ToInt32(total10) + "%. \n");
                    index++;
                }
            }
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 85);
            this.Invoke(new RefreshTextDelegate(RefreshText), "Deleting Original file... \n");
            System.IO.File.Delete(path);
        }


        public byte[] encriptArray(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 5);
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 30);
            byte[] secondHash = SHA512.Create().ComputeHash(passwordBytes);
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 50);
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 70);
            byte[] FirstEncrypt = Encrypt.AES_Encrypt(bytesToBeEncrypted, secondHash);
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 100);
            return FirstEncrypt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        ////////////////////////////////////////////////////////////



        public void EncryptDirectory(int chunkSize, string pathL, byte[] passwordBytes)
        {
            string[] files = Directory.GetFiles(pathL);
            checked
            {
                for (int i = 0; i < files.Length; i++)
                {
                    string path = files[i];
                    encryptFile(chunkSize, path, passwordBytes);
                }
                string[] directories = Directory.GetDirectories(pathL);
                for (int j = 0; j < directories.Length; j++)
                {
                    string targetDirectory2 = directories[j];
                    EncryptDirectory(chunkSize, targetDirectory2, passwordBytes);
                }
            }
        }






    }
}

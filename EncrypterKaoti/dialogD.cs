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
    public partial class dialogD : Form
    {
        bool isfile;
        String pass;
        string filename;
        ThreadStart decryptThreadStart;
        Thread decryptThread;



        public dialogD(string pathV, string passV, bool isFileArg)
        {
            InitializeComponent();
            FILE.Text = "FILE: " + pathV + (isFileArg ? "  |  PassWord File:" + passV : "");

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
        void decryptProcess()
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
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Starting decryption with a chunk size of 100000. \n");
                    decryptFile(500000, filename, passwordBytes);
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 100);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Finished! \n");
                    this.Invoke(new RefreshTextDelegate(RefreshData), "Finished!");
                    MessageBox.Show("Decrypted");
                    decryptThread.Abort();
                }
                else
                {
                    decryptThread.Abort();

                }
            }
            catch (ThreadAbortException ex)
            {
                this.Invoke(new RefreshTextDelegate(RefreshText), "Process aborted :O!  \n");
            }
        }




        public byte[] decryptArray(byte[] bytesToBeDdecrypted, byte[] passwordBytes)
        {
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 5);
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 30);
            byte[] secondHash = SHA512.Create().ComputeHash(passwordBytes);
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 50);
            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 100);
            byte[] Firstdecrypt = Decrypt.AES_Decrypt(bytesToBeDdecrypted, secondHash);

            return Firstdecrypt;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            decryptThread.Abort();
            this.Invoke(new ClearDelegate(ClearData));
            this.Invoke(new RefreshTextDelegate(RefreshData), "Stopped. Process aborted :O!!! ");

            string extension = System.IO.Path.GetExtension(filename);
            string result = filename.Substring(0, filename.Length - extension.Length);

            if (File.Exists(result) && File.Exists(filename))
            {
                this.Invoke(new RefreshTextDelegate(RefreshData), "Deleting incomplete Decrypted File.");
                System.IO.File.Delete(result);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decryptThreadStart = new ThreadStart(decryptProcess);
            decryptThread = new Thread(decryptThreadStart);
            decryptThread.Start();
            decryptThread.IsBackground = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decryptFile(int chunkSize, string path, byte[] passwordBytes)
        {
            string extension = System.IO.Path.GetExtension(path);
            string result = path.Substring(0, path.Length - extension.Length);
            File.Create(result).Dispose();
            this.Invoke(new RefreshTextDelegate(RefreshText), "Created Original file. \n");
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 10);

            byte[] buffer = new byte[chunkSize];
            List<byte> extraBuffer = new List<byte>();

            using (Stream input = File.OpenRead(path))
            {
                int index = 0;
                while (input.Position < input.Length)
                {
                    using (var output = new FileStream(result, FileMode.Append))
                    {
                        int chunkBytesRead = 0;
                        while (chunkBytesRead < chunkSize)
                        {
                            int bytesRead = input.Read(buffer, chunkBytesRead, chunkSize - chunkBytesRead);

                            if (bytesRead == 0)
                            {
                                break;
                            }

                            chunkBytesRead += bytesRead;
                        }



                        output.Write(decryptArray(buffer, passwordBytes), 0, chunkBytesRead);

                    }


                    long ind = index;
                    long longi = input.Length;
                    var total = (5000000 * 7 * ind / longi).ToString();
                    var total10 = (5000000 * 10 * ind / longi).ToString();

                    this.Invoke(new RefreshTextDelegate(RefreshData), "Longitud total: " + input.Length + "      |   Status: Decrypting.." + "      |    percent: " + total10 + "   |   Index: " + ind);
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), Convert.ToInt32(total));
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Decrypting... " + Convert.ToInt32(total10) + "%. \n");
                    
                    index++;
                }
            }

            System.IO.File.Delete(path);
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 85);
            this.Invoke(new RefreshTextDelegate(RefreshText), "Deleting Encrypted file... \n");
        }








        ///////////////////////////////////////////////////////



        //public void DecryptDirectory(int chunkSize, string pathL, byte[] passwordBytes)
        //{
        //    string[] files = Directory.GetFiles(pathL);
        //    checked
        //    {
        //        for (int i = 0; i < files.Length; i++)
        //        {
        //            string path = files[i];
        //            decryptFile(chunkSize, path, passwordBytes);
        //        }
        //        string[] directories = Directory.GetDirectories(pathL);
        //        for (int j = 0; j < directories.Length; j++)
        //        {
        //            string targetDirectory2 = directories[j];
        //            ThreadStart decryptDirThreadStart = new ThreadStart(DecryptDirectory(chunkSize, targetDirectory2, passwordBytes));
        //            Thread decryptDirThread = new Thread(decryptDirThreadStart);
        //            decryptDirThread.Start();
        //            decryptDirThread.IsBackground = true;
        //        }
        //    }
        //}




    }
}

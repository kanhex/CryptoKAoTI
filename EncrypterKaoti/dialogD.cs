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
        String pass;
        string filename;
        ThreadStart decryptThreadStart;
        Thread decryptThread;



        public dialogD(string pathV, string passV)
        {
            InitializeComponent();
            FILE.Text = "FILE: " + pathV;

            pass = passV;
            filename = pathV;






        }

        delegate void RefreshProgressDelegate(int percent);
        delegate void RefreshProgress2Delegate(int percent);
        delegate void RefreshTextDelegate(string text);

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

        void decryptProcess()
        {

            try
            {
                if (File.Exists(filename))
                {
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 5);
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(pass);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "\n Password encoded into a sequence of bytes. \n");
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 7);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Starting decryption with a chunk size of 100000. \n");
                    SplitFile(100000, filename, passwordBytes);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Finished! \n");
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

        public void decryptFile(int chunkSize, string path, byte[] passwordBytes)
        {
            string extension = System.IO.Path.GetExtension(path);
            string result = path.Substring(0, path.Length - extension.Length);
            File.Create(result).Dispose();
            this.Invoke(new RefreshTextDelegate(RefreshText), "Created Original file. \n");
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 10);
            const int BUFFER_SIZE = 20 * 1024;
            byte[] buffer = new byte[BUFFER_SIZE];

            using (Stream input = File.OpenRead(path))
            {
                int index = 0;
                while (input.Position < input.Length)
                {
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress),(int)(input.Position / input.Length) * 70);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Decrypting... " + Convert.ToString(Convert.ToInt32((input.Position / input.Length) * 100)) + "%. \n");
                    using (var output = new FileStream(result, FileMode.Append))
                    {
                        int remaining = chunkSize, bytesRead;
                        while (remaining > 0 && (bytesRead = input.Read(buffer, 0, Math.Min(remaining, BUFFER_SIZE))) > 0)
                        {
                            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 0);
                            buffer = decryptArray(buffer, passwordBytes);
                            output.Write(buffer, 0, bytesRead);
                            remaining -= bytesRead;
                        }
                    }
                    index++;
                    Thread.Sleep(100); // experimental; perhaps try it
                }
            }
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 85);
            this.Invoke(new RefreshTextDelegate(RefreshText), "Deleting Encrypted file... \n");
            System.IO.File.Delete(path);
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

        private void SplitFile(int chunkSize, string path, byte[] passwordBytes)
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
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), Convert.ToInt32((index / input.Length) * 70));
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Decrypting... " + Convert.ToString(Convert.ToInt32((index / input.Length) * 100)) + "%. \n");
                    index++;
                }
            }

            System.IO.File.Delete(path);
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 85);
            this.Invoke(new RefreshTextDelegate(RefreshText), "Deleting Encrypted file... \n");
        }


    }
}

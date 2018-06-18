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



        public dialog(string pathV, string passV)
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

        void EncryptProcess()
        {

            try
            {
                if (File.Exists(filename))
                {
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 5);
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(pass);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "\n Password encoded into a sequence of bytes. \n");
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), 7);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Starting Encryption with a chunk size of 20000. \n");
                    encryptFile(100000, filename, passwordBytes);
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Finished! \n");
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

        public void EncryptFile(int chunkSize, string path, byte[] passwordBytes)
        {

            File.Create(path + ".K4L0ckED").Dispose();
            this.Invoke(new RefreshTextDelegate(RefreshText), "Created .K4L0ckED file. \n");
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 10);
            const int BUFFER_SIZE = 20 * 1024;
            byte[] buffer = new byte[BUFFER_SIZE];

            using (Stream input = File.OpenRead(path))
            {
                int index = 0;
                while (input.Position < input.Length)
                {

                    using (var output = new FileStream(path + ".K4L0ckED", FileMode.Append))
                    {
                        int remaining = chunkSize, bytesRead;
                        while (remaining > 0 && (bytesRead = input.Read(buffer, 0, Math.Min(remaining, BUFFER_SIZE))) > 0)
                        {
                            this.Invoke(new RefreshProgress2Delegate(RefreshProgress2), 0);
                            buffer = encriptArray(buffer, passwordBytes);
                            output.Write(buffer, 0, bytesRead);
                            remaining -= bytesRead;
                        }
                    }
                    index++;
                    Thread.Sleep(100); // experimental; perhaps try it
                }
            }
            this.Invoke(new RefreshProgressDelegate(RefreshProgress), 85);
            this.Invoke(new RefreshTextDelegate(RefreshText), "Deleting Original file... \n");
            System.IO.File.Delete(path);
        }


        

        private void stopBtn_Click(object sender, EventArgs e)
        {
            encryptThread.Abort();
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

                            chunkBytesRead += bytesRead;
                        }

                        

                        output.Write(encriptArray(buffer, passwordBytes), 0, chunkBytesRead);

                    }
                    this.Invoke(new RefreshProgressDelegate(RefreshProgress), Convert.ToInt32((index / input.Length) * 70));
                    this.Invoke(new RefreshTextDelegate(RefreshText), "Encrypting... " + Convert.ToString(Convert.ToInt32((index / input.Length) * 100)) + "%. \n");
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
    }
}

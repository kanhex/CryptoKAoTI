using System;
using System.Diagnostics;
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
using System.Net;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EncrypterKaoti
{
    class Decrypt
    {

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 2, 0, 0, 4, 0, 3, 0, 3};

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {

                    AES.KeySize = 256;
                    AES.BlockSize = 256;
                    AES.Padding = PaddingMode.None;
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CFB;
                     
                        using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                            {
                            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                            cs.Close();
                         }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        public static void DecryptFile(string file, string password)
        {
            try
            {
                //file to bytes
                byte[] bytesToBeDecrypted = File.ReadAllBytes(file);
                //password to bytes
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                //calc the hash of the password
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                //calc the hash of the hash
                byte[] secondHash = SHA512.Create().ComputeHash(passwordBytes);
                //decrypt the bytes of the encrypted file with the second hash  
                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, secondHash);
                //with the above u get another encrypted array of bytes
                //calc the third hash of the second hash
                byte[] thirdHash = SHA512.Create().ComputeHash(secondHash);
                //decrypt that array with the third hash
                bytesDecrypted = AES_Decrypt(bytesDecrypted, thirdHash);

                File.WriteAllBytes(file, bytesDecrypted);
                string extension = System.IO.Path.GetExtension(file);
                string result = file.Substring(0, file.Length - extension.Length);
                System.IO.File.Move(file, result);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                
            }

        }

      
    }
}

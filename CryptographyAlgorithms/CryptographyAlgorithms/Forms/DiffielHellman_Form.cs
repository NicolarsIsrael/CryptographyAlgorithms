using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace CryptographyAlgorithms.Forms
{
    public partial class DiffielHellman_Form : Form
    {
        public DiffielHellman_Form()
        {
            InitializeComponent();
        }

        private void DiffielHellman_Form_Load(object sender, EventArgs e)
        {
            var Al = new Alice();
            using (ECDiffieHellmanCng alice = new ECDiffieHellmanCng())
            {

                alice.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                alice.HashAlgorithm = CngAlgorithm.Sha256;
                Al.alicePublicKey = alice.PublicKey.ToByteArray();
                Bob bob = new Bob(Al.alicePublicKey);
                CngKey bobKey = CngKey.Import(bob.bobPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] aliceKey = alice.DeriveKeyMaterial(bobKey);
                byte[] encryptedMessage = null;
                byte[] iv = null;
                this.label1.Text = Al.Send(aliceKey, "Secret message", out encryptedMessage, out iv);
                //this.label1.Text = bob.Receive(encryptedMessage, iv);
            }
        }
    }

    class Alice
    {
        public byte[] alicePublicKey;

        //public static void Main(string[] args)
        //{
            
        //}

        public string Send(byte[] key, string secretMessage, out byte[] encryptedMessage, out byte[] iv)
        {
            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = key;
                iv = aes.IV;

                // Encrypt the message
                using (MemoryStream ciphertext = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ciphertext, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] plaintextMessage = Encoding.UTF8.GetBytes(secretMessage);
                    cs.Write(plaintextMessage, 0, plaintextMessage.Length);
                    cs.Close();
                    encryptedMessage = ciphertext.ToArray();
                    string message = System.Text.Encoding.Default.GetString(encryptedMessage); 
                    return message;
                }
            }
        }
    }
    public class Bob
    {
        public byte[] bobPublicKey;
        private byte[] bobKey;
        public Bob(byte[] alPublicKey)
        {
            using (ECDiffieHellmanCng bob = new ECDiffieHellmanCng())
            {

                bob.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                bob.HashAlgorithm = CngAlgorithm.Sha256;
                bobPublicKey = bob.PublicKey.ToByteArray();
                bobKey = bob.DeriveKeyMaterial(CngKey.Import(alPublicKey, CngKeyBlobFormat.EccPublicBlob));
            }
        }

        public string Receive(byte[] encryptedMessage, byte[] iv)
        {

            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = bobKey;
                aes.IV = iv;
                // Decrypt the message
                using (MemoryStream plaintext = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(plaintext, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedMessage, 0, encryptedMessage.Length);
                        cs.Close();
                        string message = Encoding.UTF8.GetString(plaintext.ToArray());
                        return message;
                    }
                }
            }
        }
    }
}

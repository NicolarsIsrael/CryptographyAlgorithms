using Cryptography.Algorithms;
using CryptographyAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CryptographyAlgorithms.Forms
{
    public partial class AES_Form : Form
    {
        private readonly AES_DecryptionAlgorithm _aesDecryptionAlgorithm;
        private readonly AES_EncryptionAlgorithm _aesEncryptionAlgorithm;
        private GeneralFunction _generalFunction;
        public AES_Form()
        {
            InitializeComponent();
            _aesDecryptionAlgorithm = new AES_DecryptionAlgorithm();
            _aesEncryptionAlgorithm = new AES_EncryptionAlgorithm();
            _generalFunction = new GeneralFunction();
        }


        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            var plainText = txt_Encrypt_PlainText.Text;
            var key = txt_Encrypt_Key.Text;
            if (!_generalFunction.ValidateHexadecimal(plainText) || plainText.Length != 32)
            {
                MessageBox.Show("Enter a valid 32 bit hexadecimal value for plain text", "Plain text validation");
                return;
            }
            if (!_generalFunction.ValidateHexadecimal(key) || key.Length != 64)
            {
                MessageBox.Show("Enter a valid 64 bit hexadecimal value for key", "Key validation");
                return;
            }

            byte[] plaintextByte = _generalFunction.StringToByteArray(plainText);
            byte[] keyByte = _generalFunction.StringToByteArray(key);
            byte[] ciphertext = new byte[16];

            uint[] key_schedule = new uint[60];

            key_schedule = _aesEncryptionAlgorithm.KeyExpansion(keyByte, key_schedule, 256);
            var cipherTextByte = _aesEncryptionAlgorithm.Encrypt(plaintextByte, ciphertext, key_schedule, 256);
            var cipherText = _generalFunction.ByteArrayToString(cipherTextByte);
            txt_Encrypt_CipherText.Text = cipherText;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            var cipherText = this.txt_Decrypt_CipherText.Text;
            var key = this.txt_Decrypt_Key.Text;
            if (!_generalFunction.ValidateHexadecimal(cipherText) || cipherText.Length != 32)
            {
                MessageBox.Show("Enter a valid 32 bit hexadecimal value for cipher text", "Cipher text validation");
                return;
            }
            if (!_generalFunction.ValidateHexadecimal(key) || key.Length != 64)
            {
                MessageBox.Show("Enter a valid 64 bit hexadecimal value for key", "Key validation");
                return;
            }

            byte[] cipherTextByte = _generalFunction.StringToByteArray(cipherText);
            byte[] keyByte = _generalFunction.StringToByteArray(key);
            byte[] plaintext = new byte[16];

            uint[] key_schedule = new uint[60];

            key_schedule = _aesDecryptionAlgorithm.KeyExpansion(keyByte, key_schedule, 256);

            var originalTextByte=_aesDecryptionAlgorithm.Decrypt(cipherTextByte, plaintext, key_schedule, 256);
            var originalText = _generalFunction.ByteArrayToString(originalTextByte);
            this.txt_Decrypt_OriginalText.Text = originalText;
        }

        private void txt_Decrypt_CipherText_TextChanged(object sender, EventArgs e)
        {
            txt_Decrypt_CipherText.Text = txt_Decrypt_CipherText.Text.ToUpper();
            txt_Decrypt_CipherText.SelectionStart = txt_Decrypt_CipherText.Text.Length;
            txt_Decrypt_CipherText.SelectionLength = 0;
        }

        private void txt_Decrypt_Key_TextChanged(object sender, EventArgs e)
        {
            txt_Decrypt_Key.Text = txt_Decrypt_Key.Text.ToUpper();
            txt_Decrypt_Key.SelectionStart = txt_Decrypt_Key.Text.Length;
            txt_Decrypt_Key.SelectionLength = 0;
        }

        private void txt_Encrypt_PlainText_TextChanged(object sender, EventArgs e)
        {
            txt_Encrypt_PlainText.Text = txt_Encrypt_PlainText.Text.ToUpper();
            txt_Encrypt_PlainText.SelectionStart = txt_Encrypt_PlainText.Text.Length;
            txt_Encrypt_PlainText.SelectionLength = 0;
        }

        private void txt_Encrypt_Key_TextChanged(object sender, EventArgs e)
        {
            txt_Encrypt_Key.Text = txt_Encrypt_Key.Text.ToUpper();
            txt_Encrypt_Key.SelectionStart = txt_Encrypt_Key.Text.Length;
            txt_Encrypt_Key.SelectionLength = 0;
        }
    }
}

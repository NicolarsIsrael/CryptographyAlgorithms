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
        private GeneralFunction _generalFunction;
        public AES_Form()
        {
            InitializeComponent();
            _aesDecryptionAlgorithm = new AES_DecryptionAlgorithm();
            _generalFunction = new GeneralFunction();
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            var cipherText = this.txt_Decrypt_CipherText.Text;
            var key = this.txt_Decrypt_Key.Text;
            if (!_generalFunction.ValidateHexadecimal(cipherText) || cipherText.Length != 32)
            {
                MessageBox.Show("Enter a valid 32 bit hexadecimal value for plain text", "Plain text validation");
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
    }
}

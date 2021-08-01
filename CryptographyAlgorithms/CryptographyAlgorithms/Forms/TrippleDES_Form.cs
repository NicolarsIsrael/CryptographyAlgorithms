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
    public partial class TrippleDES_Form : Form
    {
        private readonly GeneralFunction generalFunction;
        private DES_Cryptography desCryptography;
        public TrippleDES_Form()
        {
            InitializeComponent();
            this.lbl_TrippleDes_Cryptography.Font = new Font("Arial", 20, FontStyle.Regular);
            this.lbl_TrippleDes_Cryptography.Location = new Point(250, 5);
            generalFunction = new GeneralFunction();
            desCryptography = new DES_Cryptography();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string plainText = this.txt_Encrypt_PlainText.Text.ToString();
            string key = this.txt_Encrypt_Key.Text.ToString();

            if (!generalFunction.ValidateHexadecimal(plainText) || plainText.Length != 16)
            {
                MessageBox.Show("Enter a valid 16 bit hexadecimal value for plain text", "Plain text validation");
                return;
            }
            if (!generalFunction.ValidateHexadecimal(key) || key.Length != 48)
            {
                MessageBox.Show("Enter a valid 48 bit hexadecimal value for key", "Key validation");
                return;
            }

            byte[] textAsByte = generalFunction.StringToByteArray(plainText);
            byte[] keyAsByte = generalFunction.StringToByteArray(key);

            byte[] k1 = new byte[8];
            byte[] k2 = new byte[8];
            byte[] k3 = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                k1[i] = keyAsByte[i];
            }
            for (int i = 8, j = 0; i < 16; i++, j++)
            {
                k2[j] = keyAsByte[i];
            }
            for (int i = 16, j = 0; i < 24; i++, j++)
            {
                k3[j] = keyAsByte[i];
            }



            byte[] output = new byte[8];
            byte[,] schedule = new byte[16, 6];

            desCryptography.KeySchedule(k1, schedule, DES_Cryptography.ENCRYPT);
            var cipherTextByte = desCryptography.Crypt(textAsByte, output, generalFunction.ToJaggedArray(schedule));

            output = new byte[8];
            schedule = new byte[16, 6];

            desCryptography.KeySchedule(k2, schedule, DES_Cryptography.DECRYPT);
            cipherTextByte = desCryptography.Crypt(cipherTextByte, output, generalFunction.ToJaggedArray(schedule));

            output = new byte[8];
            schedule = new byte[16, 6];

            desCryptography.KeySchedule(k3, schedule, DES_Cryptography.ENCRYPT);
            cipherTextByte = desCryptography.Crypt(cipherTextByte, output, generalFunction.ToJaggedArray(schedule));

            string cipherText = generalFunction.ByteArrayToString(cipherTextByte);
            this.txt_Encrypt_CipherText.Text = cipherText;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string cipherText = this.txt_Decrypt_CipherText.Text.ToString();
            string key = this.txt_Decrypt_Key.Text.ToString();

            if (!generalFunction.ValidateHexadecimal(cipherText) || cipherText.Length != 16)
            {
                MessageBox.Show("Enter a valid 16 bit hexadecimal value for cipher text", "Cipher text validation");
                return;
            }
            if (!generalFunction.ValidateHexadecimal(key) || key.Length != 48)
            {
                MessageBox.Show("Enter a valid 48 bit hexadecimal value for key", "Key validation");
                return;
            }

            byte[] textAsByte = generalFunction.StringToByteArray(cipherText);
            byte[] keyAsByte = generalFunction.StringToByteArray(key);

            byte[] k1 = new byte[8];
            byte[] k2 = new byte[8];
            byte[] k3 = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                k1[i] = keyAsByte[i];
            }
            for (int i = 8, j = 0; i < 16; i++, j++)
            {
                k2[j] = keyAsByte[i];
            }
            for (int i = 16, j = 0; i < 24; i++, j++)
            {
                k3[j] = keyAsByte[i];
            }

            byte[] output = new byte[8];
            byte[,] schedule = new byte[16, 6];

            desCryptography.KeySchedule(k3, schedule, DES_Cryptography.DECRYPT);
            var originalTextByte = desCryptography.Crypt(textAsByte, output, generalFunction.ToJaggedArray(schedule));

            output = new byte[8];
            schedule = new byte[16, 6];

            desCryptography.KeySchedule(k2, schedule, DES_Cryptography.ENCRYPT);
            originalTextByte = desCryptography.Crypt(originalTextByte, output, generalFunction.ToJaggedArray(schedule));

            output = new byte[8];
            schedule = new byte[16, 6];

            desCryptography.KeySchedule(k1, schedule, DES_Cryptography.DECRYPT);
            originalTextByte = desCryptography.Crypt(originalTextByte, output, generalFunction.ToJaggedArray(schedule));

            string originalText = generalFunction.ByteArrayToString(originalTextByte);
            this.txt_Decrypt_OriginalText.Text = originalText;
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
    }
}

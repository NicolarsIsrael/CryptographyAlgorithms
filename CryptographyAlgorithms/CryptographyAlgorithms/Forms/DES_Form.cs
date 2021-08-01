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
    public partial class DES_Form : Form
    {
        private readonly GeneralFunction generalFunction;
        public DES_Form()
        {
            InitializeComponent();
            generalFunction = new GeneralFunction();
            this.lbl_des_cryptography.Font = new Font("Arial", 20, FontStyle.Regular);
            this.lbl_des_cryptography.Location = new Point(250, 5);
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            var desCryptography = new DES_Cryptography();
            string plainText = this.txt_Encryp_PlainText.Text.ToString();
            string key = this.txt_Encryp_Key.Text.ToString();

            if (!generalFunction.ValidateHexadecimal(plainText) || plainText.Length != 16)
            {
                MessageBox.Show("Enter a valid 16 bit hexadecimal value for plain text", "Plain text validation");
                return;
            }
            if (!generalFunction.ValidateHexadecimal(key) || key.Length != 16)
            {
                MessageBox.Show("Enter a valid 16 bit hexadecimal value for key", "Key validation");
                return;
            }

            byte[] textAsByte = generalFunction.StringToByteArray(plainText);
            byte[] keyAsByte = generalFunction.StringToByteArray(key);
            byte[] output = new byte[8];
            byte[,] schedule = new byte[16, 6];

            desCryptography.KeySchedule(keyAsByte, schedule, DES_Cryptography.ENCRYPT);
            var cipherTextByte = desCryptography.Crypt(textAsByte, output, generalFunction.ToJaggedArray(schedule));
            string cipherText = generalFunction.ByteArrayToString(cipherTextByte);
            this.txt_Encryp_CipherText.Text = cipherText;

            //desCryptography.KeySchedule(keyAsByte, schedule, DES_Cryptography.DECRYPT);
            //desCryptography.Crypt(output, textAsByte, generalFunction.ToJaggedArray(schedule));
            //Console.Write("Decrypt Output: ");
            //string cipherText = generalFunction.ByteArrayToString(textAsByte);

            //this.txt_cipherText.Text = cipherText;
        }

        private void txt_Encryp_PlainText_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Encryp_PlainText_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_Encryp_PlainText_TextChanged(object sender, EventArgs e)
        {
            txt_Encryp_PlainText.Text = txt_Encryp_PlainText.Text.ToUpper();
            txt_Encryp_PlainText.SelectionStart = txt_Encryp_PlainText.Text.Length;
            txt_Encryp_PlainText.SelectionLength = 0;
        }

        private void txt_Encryp_Key_TextChanged(object sender, EventArgs e)
        {
            txt_Encryp_Key.Text = txt_Encryp_Key.Text.ToUpper();
            txt_Encryp_Key.SelectionStart = txt_Encryp_Key.Text.Length;
            txt_Encryp_Key.SelectionLength = 0;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            var desCryptography = new DES_Cryptography();
            string cipherText = this.txt_Decrpyt_CipherText.Text.ToString();
            string key = this.txt_Decrypt_key.Text.ToString();

            if (!generalFunction.ValidateHexadecimal(cipherText) || cipherText.Length != 16)
            {
                MessageBox.Show("Enter a valid 16 bit hexadecimal value for cipher text", "Cipher text validation");
                return;
            }
            if (!generalFunction.ValidateHexadecimal(key) || key.Length != 16)
            {
                MessageBox.Show("Enter a valid 16 bit hexadecimal value for key", "Key validation");
                return;
            }

            byte[] textAsByte = generalFunction.StringToByteArray(cipherText);
            byte[] keyAsByte = generalFunction.StringToByteArray(key);
            byte[] output = new byte[8];
            byte[,] schedule = new byte[16, 6];

            desCryptography.KeySchedule(keyAsByte, schedule, DES_Cryptography.DECRYPT);
            var originalTextByte = desCryptography.Crypt(textAsByte,output, generalFunction.ToJaggedArray(schedule));
            string originalText = generalFunction.ByteArrayToString(originalTextByte);
            this.txt_Decrypt_OriginalText.Text = originalText;
        }

        private void txt_Decrpyt_CipherText_TextChanged(object sender, EventArgs e)
        {
            txt_Decrpyt_CipherText.Text = txt_Decrpyt_CipherText.Text.ToUpper();
            txt_Decrpyt_CipherText.SelectionStart = txt_Decrpyt_CipherText.Text.Length;
            txt_Decrpyt_CipherText.SelectionLength = 0;
        }

        private void txt_Decrypt_key_TextChanged(object sender, EventArgs e)
        {
            txt_Decrypt_key.Text = txt_Decrypt_key.Text.ToUpper();
            txt_Decrypt_key.SelectionStart = txt_Decrypt_key.Text.Length;
            txt_Decrypt_key.SelectionLength = 0;
        }

    }
}

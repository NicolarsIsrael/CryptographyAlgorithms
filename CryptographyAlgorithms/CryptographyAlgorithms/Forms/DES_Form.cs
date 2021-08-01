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
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            var desCryptography = new DES_Cryptography();
            string plainText = this.txt_Encryp_PlainText.Text.ToString();
            string key = this.txt_Encryp_Key.Text.ToString();

            byte[] textAsByte = generalFunction.StringToByteArray(plainText);
            byte[] keyAsByte = generalFunction.StringToByteArray(key);

            //byte[] text = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xE7 };
            //byte[] key = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
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
    }
}

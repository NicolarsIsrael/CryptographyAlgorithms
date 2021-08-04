using CryptographyAlgorithms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DesCryptography_Click(object sender, EventArgs e)
        {
            DES_Form desForm = new DES_Form();
            desForm.Show();
        }

        private void btn_AES_Cryptography_Click(object sender, EventArgs e)
        {
            AES_Form aesForm = new AES_Form();
            aesForm.Show();
        }

        private void btn_TrippleDES_Click(object sender, EventArgs e)
        {
            TrippleDES_Form trippleDesForm = new TrippleDES_Form();
            trippleDesForm.Show();
        }

        private void btn_DiffielHellman_Cryptography_Click(object sender, EventArgs e)
        {
            DiffielHellman_Form diffielHellman_Form = new DiffielHellman_Form();
            diffielHellman_Form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_RSA_Crypto_Click(object sender, EventArgs e)
        {
            RSA_Form rsaForm = new RSA_Form();
            rsaForm.Show();
        }
    }
}

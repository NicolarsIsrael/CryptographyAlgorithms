﻿using CryptographyAlgorithms.Forms;
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
    }
}
namespace CryptographyAlgorithms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DesCryptography = new System.Windows.Forms.Button();
            this.btn_AES_Cryptography = new System.Windows.Forms.Button();
            this.btn_TrippleDES = new System.Windows.Forms.Button();
            this.grpBox_SymmetricCryptography = new System.Windows.Forms.GroupBox();
            this.grp_Asymmetric = new System.Windows.Forms.GroupBox();
            this.btn_RSA_Crypto = new System.Windows.Forms.Button();
            this.btn_DiffielHellman_Cryptography = new System.Windows.Forms.Button();
            this.grpBox_SymmetricCryptography.SuspendLayout();
            this.grp_Asymmetric.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cryptography";
            // 
            // btn_DesCryptography
            // 
            this.btn_DesCryptography.Location = new System.Drawing.Point(37, 41);
            this.btn_DesCryptography.Name = "btn_DesCryptography";
            this.btn_DesCryptography.Size = new System.Drawing.Size(241, 23);
            this.btn_DesCryptography.TabIndex = 1;
            this.btn_DesCryptography.Text = "DES Cryptography";
            this.btn_DesCryptography.UseVisualStyleBackColor = true;
            this.btn_DesCryptography.Click += new System.EventHandler(this.btn_DesCryptography_Click);
            // 
            // btn_AES_Cryptography
            // 
            this.btn_AES_Cryptography.Location = new System.Drawing.Point(37, 118);
            this.btn_AES_Cryptography.Name = "btn_AES_Cryptography";
            this.btn_AES_Cryptography.Size = new System.Drawing.Size(241, 23);
            this.btn_AES_Cryptography.TabIndex = 2;
            this.btn_AES_Cryptography.Text = "AES Cryptography";
            this.btn_AES_Cryptography.UseVisualStyleBackColor = true;
            this.btn_AES_Cryptography.Click += new System.EventHandler(this.btn_AES_Cryptography_Click);
            // 
            // btn_TrippleDES
            // 
            this.btn_TrippleDES.Location = new System.Drawing.Point(37, 80);
            this.btn_TrippleDES.Name = "btn_TrippleDES";
            this.btn_TrippleDES.Size = new System.Drawing.Size(241, 23);
            this.btn_TrippleDES.TabIndex = 3;
            this.btn_TrippleDES.Text = "Tripple DES Cryptography";
            this.btn_TrippleDES.UseVisualStyleBackColor = true;
            this.btn_TrippleDES.Click += new System.EventHandler(this.btn_TrippleDES_Click);
            // 
            // grpBox_SymmetricCryptography
            // 
            this.grpBox_SymmetricCryptography.Controls.Add(this.btn_DesCryptography);
            this.grpBox_SymmetricCryptography.Controls.Add(this.btn_TrippleDES);
            this.grpBox_SymmetricCryptography.Controls.Add(this.btn_AES_Cryptography);
            this.grpBox_SymmetricCryptography.Location = new System.Drawing.Point(26, 68);
            this.grpBox_SymmetricCryptography.Name = "grpBox_SymmetricCryptography";
            this.grpBox_SymmetricCryptography.Size = new System.Drawing.Size(333, 205);
            this.grpBox_SymmetricCryptography.TabIndex = 4;
            this.grpBox_SymmetricCryptography.TabStop = false;
            this.grpBox_SymmetricCryptography.Text = "Symmetric Cryptography";
            // 
            // grp_Asymmetric
            // 
            this.grp_Asymmetric.Controls.Add(this.btn_RSA_Crypto);
            this.grp_Asymmetric.Controls.Add(this.btn_DiffielHellman_Cryptography);
            this.grp_Asymmetric.Location = new System.Drawing.Point(430, 68);
            this.grp_Asymmetric.Name = "grp_Asymmetric";
            this.grp_Asymmetric.Size = new System.Drawing.Size(333, 205);
            this.grp_Asymmetric.TabIndex = 5;
            this.grp_Asymmetric.TabStop = false;
            this.grp_Asymmetric.Text = "Asymmetric Cryptography";
            // 
            // btn_RSA_Crypto
            // 
            this.btn_RSA_Crypto.Location = new System.Drawing.Point(46, 41);
            this.btn_RSA_Crypto.Name = "btn_RSA_Crypto";
            this.btn_RSA_Crypto.Size = new System.Drawing.Size(241, 23);
            this.btn_RSA_Crypto.TabIndex = 1;
            this.btn_RSA_Crypto.Text = "Rivest-Shamir-Adleman (RSA)";
            this.btn_RSA_Crypto.UseVisualStyleBackColor = true;
            this.btn_RSA_Crypto.Click += new System.EventHandler(this.btn_RSA_Crypto_Click);
            // 
            // btn_DiffielHellman_Cryptography
            // 
            this.btn_DiffielHellman_Cryptography.Location = new System.Drawing.Point(46, 80);
            this.btn_DiffielHellman_Cryptography.Name = "btn_DiffielHellman_Cryptography";
            this.btn_DiffielHellman_Cryptography.Size = new System.Drawing.Size(241, 23);
            this.btn_DiffielHellman_Cryptography.TabIndex = 0;
            this.btn_DiffielHellman_Cryptography.Text = "Diffiel Hellman Cryptography";
            this.btn_DiffielHellman_Cryptography.UseVisualStyleBackColor = true;
            this.btn_DiffielHellman_Cryptography.Click += new System.EventHandler(this.btn_DiffielHellman_Cryptography_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_Asymmetric);
            this.Controls.Add(this.grpBox_SymmetricCryptography);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox_SymmetricCryptography.ResumeLayout(false);
            this.grp_Asymmetric.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DesCryptography;
        private System.Windows.Forms.Button btn_AES_Cryptography;
        private System.Windows.Forms.Button btn_TrippleDES;
        private System.Windows.Forms.GroupBox grpBox_SymmetricCryptography;
        private System.Windows.Forms.GroupBox grp_Asymmetric;
        private System.Windows.Forms.Button btn_DiffielHellman_Cryptography;
        private System.Windows.Forms.Button btn_RSA_Crypto;
    }
}


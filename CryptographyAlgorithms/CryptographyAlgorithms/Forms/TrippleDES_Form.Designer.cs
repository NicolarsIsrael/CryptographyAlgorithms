namespace CryptographyAlgorithms.Forms
{
    partial class TrippleDES_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.txt_Encrypt_CipherText = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_CipherText = new System.Windows.Forms.Label();
            this.txt_Encrypt_Key = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_Key = new System.Windows.Forms.Label();
            this.txt_Encrypt_PlainText = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_PlainText = new System.Windows.Forms.Label();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txt_Decrypt_OriginalText = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_OriginalText = new System.Windows.Forms.Label();
            this.txt_Decrypt_Key = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_Key = new System.Windows.Forms.Label();
            this.txt_Decrypt_CipherText = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_CipherText = new System.Windows.Forms.Label();
            this.lbl_TrippleDes_Cryptography = new System.Windows.Forms.Label();
            this.grpBox_Encrypt = new System.Windows.Forms.GroupBox();
            this.grpBox_Encryption = new System.Windows.Forms.GroupBox();
            this.grpBox_Encrypt.SuspendLayout();
            this.grpBox_Encryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(23, 285);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 6;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // txt_Encrypt_CipherText
            // 
            this.txt_Encrypt_CipherText.Location = new System.Drawing.Point(23, 230);
            this.txt_Encrypt_CipherText.Name = "txt_Encrypt_CipherText";
            this.txt_Encrypt_CipherText.ReadOnly = true;
            this.txt_Encrypt_CipherText.Size = new System.Drawing.Size(262, 23);
            this.txt_Encrypt_CipherText.TabIndex = 5;
            // 
            // lbl_Encrypt_CipherText
            // 
            this.lbl_Encrypt_CipherText.AutoSize = true;
            this.lbl_Encrypt_CipherText.Location = new System.Drawing.Point(23, 211);
            this.lbl_Encrypt_CipherText.Name = "lbl_Encrypt_CipherText";
            this.lbl_Encrypt_CipherText.Size = new System.Drawing.Size(65, 15);
            this.lbl_Encrypt_CipherText.TabIndex = 4;
            this.lbl_Encrypt_CipherText.Text = "Cipher text";
            // 
            // txt_Encrypt_Key
            // 
            this.txt_Encrypt_Key.Location = new System.Drawing.Point(23, 141);
            this.txt_Encrypt_Key.Name = "txt_Encrypt_Key";
            this.txt_Encrypt_Key.Size = new System.Drawing.Size(262, 23);
            this.txt_Encrypt_Key.TabIndex = 3;
            this.txt_Encrypt_Key.TextChanged += new System.EventHandler(this.txt_Encrypt_Key_TextChanged);
            // 
            // lbl_Encrypt_Key
            // 
            this.lbl_Encrypt_Key.AutoSize = true;
            this.lbl_Encrypt_Key.Location = new System.Drawing.Point(23, 123);
            this.lbl_Encrypt_Key.Name = "lbl_Encrypt_Key";
            this.lbl_Encrypt_Key.Size = new System.Drawing.Size(144, 15);
            this.lbl_Encrypt_Key.TabIndex = 2;
            this.lbl_Encrypt_Key.Text = "Key ( 48 bit Hexadecimal )";
            // 
            // txt_Encrypt_PlainText
            // 
            this.txt_Encrypt_PlainText.Location = new System.Drawing.Point(23, 51);
            this.txt_Encrypt_PlainText.Name = "txt_Encrypt_PlainText";
            this.txt_Encrypt_PlainText.Size = new System.Drawing.Size(262, 23);
            this.txt_Encrypt_PlainText.TabIndex = 1;
            this.txt_Encrypt_PlainText.TextChanged += new System.EventHandler(this.txt_Encrypt_PlainText_TextChanged);
            // 
            // lbl_Encrypt_PlainText
            // 
            this.lbl_Encrypt_PlainText.AutoSize = true;
            this.lbl_Encrypt_PlainText.Location = new System.Drawing.Point(23, 33);
            this.lbl_Encrypt_PlainText.Name = "lbl_Encrypt_PlainText";
            this.lbl_Encrypt_PlainText.Size = new System.Drawing.Size(171, 15);
            this.lbl_Encrypt_PlainText.TabIndex = 0;
            this.lbl_Encrypt_PlainText.Text = "Plain text (16 bit Hexadecimal )";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(23, 285);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 6;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            // 
            // txt_Decrypt_OriginalText
            // 
            this.txt_Decrypt_OriginalText.Location = new System.Drawing.Point(23, 230);
            this.txt_Decrypt_OriginalText.Name = "txt_Decrypt_OriginalText";
            this.txt_Decrypt_OriginalText.ReadOnly = true;
            this.txt_Decrypt_OriginalText.Size = new System.Drawing.Size(262, 23);
            this.txt_Decrypt_OriginalText.TabIndex = 5;
            // 
            // lbl_Decrypt_OriginalText
            // 
            this.lbl_Decrypt_OriginalText.AutoSize = true;
            this.lbl_Decrypt_OriginalText.Location = new System.Drawing.Point(23, 211);
            this.lbl_Decrypt_OriginalText.Name = "lbl_Decrypt_OriginalText";
            this.lbl_Decrypt_OriginalText.Size = new System.Drawing.Size(79, 15);
            this.lbl_Decrypt_OriginalText.TabIndex = 4;
            this.lbl_Decrypt_OriginalText.Text = "Origninal text";
            // 
            // txt_Decrypt_Key
            // 
            this.txt_Decrypt_Key.Location = new System.Drawing.Point(23, 141);
            this.txt_Decrypt_Key.Name = "txt_Decrypt_Key";
            this.txt_Decrypt_Key.Size = new System.Drawing.Size(262, 23);
            this.txt_Decrypt_Key.TabIndex = 3;
            // 
            // lbl_Decrypt_Key
            // 
            this.lbl_Decrypt_Key.AutoSize = true;
            this.lbl_Decrypt_Key.Location = new System.Drawing.Point(23, 123);
            this.lbl_Decrypt_Key.Name = "lbl_Decrypt_Key";
            this.lbl_Decrypt_Key.Size = new System.Drawing.Size(144, 15);
            this.lbl_Decrypt_Key.TabIndex = 2;
            this.lbl_Decrypt_Key.Text = "Key ( 48 bit Hexadecimal )";
            // 
            // txt_Decrypt_CipherText
            // 
            this.txt_Decrypt_CipherText.Location = new System.Drawing.Point(23, 51);
            this.txt_Decrypt_CipherText.Name = "txt_Decrypt_CipherText";
            this.txt_Decrypt_CipherText.Size = new System.Drawing.Size(262, 23);
            this.txt_Decrypt_CipherText.TabIndex = 1;
            // 
            // lbl_Decrypt_CipherText
            // 
            this.lbl_Decrypt_CipherText.AutoSize = true;
            this.lbl_Decrypt_CipherText.Location = new System.Drawing.Point(23, 33);
            this.lbl_Decrypt_CipherText.Name = "lbl_Decrypt_CipherText";
            this.lbl_Decrypt_CipherText.Size = new System.Drawing.Size(183, 15);
            this.lbl_Decrypt_CipherText.TabIndex = 0;
            this.lbl_Decrypt_CipherText.Text = "Cipher text ( 16 bit Hexadecimal )";
            // 
            // lbl_TrippleDes_Cryptography
            // 
            this.lbl_TrippleDes_Cryptography.AutoSize = true;
            this.lbl_TrippleDes_Cryptography.Location = new System.Drawing.Point(98, 33);
            this.lbl_TrippleDes_Cryptography.Name = "lbl_TrippleDes_Cryptography";
            this.lbl_TrippleDes_Cryptography.Size = new System.Drawing.Size(164, 15);
            this.lbl_TrippleDes_Cryptography.TabIndex = 1;
            this.lbl_TrippleDes_Cryptography.Text = "TRIPPLE DES CRYPTOGRAPHY";
            // 
            // grpBox_Encrypt
            // 
            this.grpBox_Encrypt.Controls.Add(this.btn_Encrypt);
            this.grpBox_Encrypt.Controls.Add(this.txt_Encrypt_CipherText);
            this.grpBox_Encrypt.Controls.Add(this.lbl_Encrypt_CipherText);
            this.grpBox_Encrypt.Controls.Add(this.txt_Encrypt_Key);
            this.grpBox_Encrypt.Controls.Add(this.lbl_Encrypt_Key);
            this.grpBox_Encrypt.Controls.Add(this.txt_Encrypt_PlainText);
            this.grpBox_Encrypt.Controls.Add(this.lbl_Encrypt_PlainText);
            this.grpBox_Encrypt.Location = new System.Drawing.Point(46, 76);
            this.grpBox_Encrypt.Name = "grpBox_Encrypt";
            this.grpBox_Encrypt.Size = new System.Drawing.Size(317, 341);
            this.grpBox_Encrypt.TabIndex = 0;
            this.grpBox_Encrypt.TabStop = false;
            this.grpBox_Encrypt.Text = "Encryption";
            // 
            // grpBox_Encryption
            // 
            this.grpBox_Encryption.Controls.Add(this.btn_Decrypt);
            this.grpBox_Encryption.Controls.Add(this.txt_Decrypt_OriginalText);
            this.grpBox_Encryption.Controls.Add(this.lbl_Decrypt_OriginalText);
            this.grpBox_Encryption.Controls.Add(this.txt_Decrypt_Key);
            this.grpBox_Encryption.Controls.Add(this.lbl_Decrypt_Key);
            this.grpBox_Encryption.Controls.Add(this.txt_Decrypt_CipherText);
            this.grpBox_Encryption.Controls.Add(this.lbl_Decrypt_CipherText);
            this.grpBox_Encryption.Location = new System.Drawing.Point(438, 76);
            this.grpBox_Encryption.Name = "grpBox_Encryption";
            this.grpBox_Encryption.Size = new System.Drawing.Size(317, 341);
            this.grpBox_Encryption.TabIndex = 0;
            this.grpBox_Encryption.TabStop = false;
            this.grpBox_Encryption.Text = "Decryption";
            // 
            // TrippleDES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBox_Encryption);
            this.Controls.Add(this.grpBox_Encrypt);
            this.Controls.Add(this.lbl_TrippleDes_Cryptography);
            this.Name = "TrippleDES_Form";
            this.Text = "TrippleDES_Form";
            this.grpBox_Encrypt.ResumeLayout(false);
            this.grpBox_Encrypt.PerformLayout();
            this.grpBox_Encryption.ResumeLayout(false);
            this.grpBox_Encryption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox txt_Encrypt_CipherText;
        private System.Windows.Forms.Label lbl_Encrypt_CipherText;
        private System.Windows.Forms.TextBox txt_Encrypt_Key;
        private System.Windows.Forms.Label lbl_Encrypt_Key;
        private System.Windows.Forms.TextBox txt_Encrypt_PlainText;
        private System.Windows.Forms.Label lbl_Encrypt_PlainText;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txt_Decrypt_OriginalText;
        private System.Windows.Forms.Label lbl_Decrypt_OriginalText;
        private System.Windows.Forms.TextBox txt_Decrypt_Key;
        private System.Windows.Forms.Label lbl_Decrypt_Key;
        private System.Windows.Forms.TextBox txt_Decrypt_CipherText;
        private System.Windows.Forms.Label lbl_Decrypt_CipherText;
        private System.Windows.Forms.Label lbl_TrippleDes_Cryptography;
        private System.Windows.Forms.GroupBox grpBox_Encrypt;
        private System.Windows.Forms.GroupBox grpBox_Encryption;
    }
}
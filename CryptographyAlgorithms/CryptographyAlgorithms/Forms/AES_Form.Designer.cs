namespace CryptographyAlgorithms.Forms
{
    partial class AES_Form
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
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txt_Decrypt_OriginalText = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_OriginalText = new System.Windows.Forms.Label();
            this.txt_Decrypt_Key = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_Key = new System.Windows.Forms.Label();
            this.txt_Decrypt_CipherText = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_CipherText = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.txt_Encrypt_CipherText = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_CipherText = new System.Windows.Forms.Label();
            this.txt_Encrypt_Key = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_key = new System.Windows.Forms.Label();
            this.txt_Encrypt_PlainText = new System.Windows.Forms.TextBox();
            this.lbl_Encrypt_PlainText = new System.Windows.Forms.Label();
            this.grp_Box_Decrypt = new System.Windows.Forms.GroupBox();
            this.grp_box_Encrypt = new System.Windows.Forms.GroupBox();
            this.lbl_AES_Cryptography = new System.Windows.Forms.Label();
            this.grp_Box_Decrypt.SuspendLayout();
            this.grp_box_Encrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(23, 285);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 6;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
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
            this.txt_Decrypt_Key.TextChanged += new System.EventHandler(this.txt_Decrypt_Key_TextChanged);
            // 
            // lbl_Decrypt_Key
            // 
            this.lbl_Decrypt_Key.AutoSize = true;
            this.lbl_Decrypt_Key.Location = new System.Drawing.Point(23, 123);
            this.lbl_Decrypt_Key.Name = "lbl_Decrypt_Key";
            this.lbl_Decrypt_Key.Size = new System.Drawing.Size(144, 15);
            this.lbl_Decrypt_Key.TabIndex = 2;
            this.lbl_Decrypt_Key.Text = "Key ( 64 bit Hexadecimal )";
            // 
            // txt_Decrypt_CipherText
            // 
            this.txt_Decrypt_CipherText.Location = new System.Drawing.Point(23, 51);
            this.txt_Decrypt_CipherText.Name = "txt_Decrypt_CipherText";
            this.txt_Decrypt_CipherText.Size = new System.Drawing.Size(262, 23);
            this.txt_Decrypt_CipherText.TabIndex = 1;
            this.txt_Decrypt_CipherText.TextChanged += new System.EventHandler(this.txt_Decrypt_CipherText_TextChanged);
            // 
            // lbl_Decrypt_CipherText
            // 
            this.lbl_Decrypt_CipherText.AutoSize = true;
            this.lbl_Decrypt_CipherText.Location = new System.Drawing.Point(23, 33);
            this.lbl_Decrypt_CipherText.Name = "lbl_Decrypt_CipherText";
            this.lbl_Decrypt_CipherText.Size = new System.Drawing.Size(183, 15);
            this.lbl_Decrypt_CipherText.TabIndex = 0;
            this.lbl_Decrypt_CipherText.Text = "Cipher text ( 32 bit Hexadecimal )";
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
            // lbl_Encrypt_key
            // 
            this.lbl_Encrypt_key.AutoSize = true;
            this.lbl_Encrypt_key.Location = new System.Drawing.Point(23, 123);
            this.lbl_Encrypt_key.Name = "lbl_Encrypt_key";
            this.lbl_Encrypt_key.Size = new System.Drawing.Size(144, 15);
            this.lbl_Encrypt_key.TabIndex = 2;
            this.lbl_Encrypt_key.Text = "Key ( 64 bit Hexadecimal )";
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
            this.lbl_Encrypt_PlainText.Text = "Plain text (32 bit Hexadecimal )";
            // 
            // grp_Box_Decrypt
            // 
            this.grp_Box_Decrypt.Controls.Add(this.btn_Decrypt);
            this.grp_Box_Decrypt.Controls.Add(this.txt_Decrypt_OriginalText);
            this.grp_Box_Decrypt.Controls.Add(this.lbl_Decrypt_OriginalText);
            this.grp_Box_Decrypt.Controls.Add(this.txt_Decrypt_Key);
            this.grp_Box_Decrypt.Controls.Add(this.lbl_Decrypt_Key);
            this.grp_Box_Decrypt.Controls.Add(this.txt_Decrypt_CipherText);
            this.grp_Box_Decrypt.Controls.Add(this.lbl_Decrypt_CipherText);
            this.grp_Box_Decrypt.Location = new System.Drawing.Point(438, 55);
            this.grp_Box_Decrypt.Name = "grp_Box_Decrypt";
            this.grp_Box_Decrypt.Size = new System.Drawing.Size(317, 341);
            this.grp_Box_Decrypt.TabIndex = 0;
            this.grp_Box_Decrypt.TabStop = false;
            this.grp_Box_Decrypt.Text = "Decryption";
            // 
            // grp_box_Encrypt
            // 
            this.grp_box_Encrypt.Controls.Add(this.btn_Encrypt);
            this.grp_box_Encrypt.Controls.Add(this.txt_Encrypt_CipherText);
            this.grp_box_Encrypt.Controls.Add(this.lbl_Encrypt_CipherText);
            this.grp_box_Encrypt.Controls.Add(this.txt_Encrypt_Key);
            this.grp_box_Encrypt.Controls.Add(this.lbl_Encrypt_key);
            this.grp_box_Encrypt.Controls.Add(this.txt_Encrypt_PlainText);
            this.grp_box_Encrypt.Controls.Add(this.lbl_Encrypt_PlainText);
            this.grp_box_Encrypt.Location = new System.Drawing.Point(46, 55);
            this.grp_box_Encrypt.Name = "grp_box_Encrypt";
            this.grp_box_Encrypt.Size = new System.Drawing.Size(317, 341);
            this.grp_box_Encrypt.TabIndex = 0;
            this.grp_box_Encrypt.TabStop = false;
            this.grp_box_Encrypt.Text = "Encryption";
            // 
            // lbl_AES_Cryptography
            // 
            this.lbl_AES_Cryptography.AutoSize = true;
            this.lbl_AES_Cryptography.Location = new System.Drawing.Point(341, 21);
            this.lbl_AES_Cryptography.Name = "lbl_AES_Cryptography";
            this.lbl_AES_Cryptography.Size = new System.Drawing.Size(112, 15);
            this.lbl_AES_Cryptography.TabIndex = 7;
            this.lbl_AES_Cryptography.Text = "AES CRYPTOGRAPH";
            // 
            // AES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_AES_Cryptography);
            this.Controls.Add(this.grp_box_Encrypt);
            this.Controls.Add(this.grp_Box_Decrypt);
            this.Name = "AES_Form";
            this.Text = "AES_Form";
            this.grp_Box_Decrypt.ResumeLayout(false);
            this.grp_Box_Decrypt.PerformLayout();
            this.grp_box_Encrypt.ResumeLayout(false);
            this.grp_box_Encrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txt_Decrypt_OriginalText;
        private System.Windows.Forms.Label lbl_Decrypt_OriginalText;
        private System.Windows.Forms.TextBox txt_Decrypt_Key;
        private System.Windows.Forms.Label lbl_Decrypt_Key;
        private System.Windows.Forms.TextBox txt_Decrypt_CipherText;
        private System.Windows.Forms.Label lbl_Decrypt_CipherText;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox txt_Encrypt_CipherText;
        private System.Windows.Forms.Label lbl_Encrypt_CipherText;
        private System.Windows.Forms.TextBox txt_Encrypt_Key;
        private System.Windows.Forms.Label lbl_Encrypt_key;
        private System.Windows.Forms.TextBox txt_Encrypt_PlainText;
        private System.Windows.Forms.Label lbl_Encrypt_PlainText;
        private System.Windows.Forms.GroupBox grp_Box_Decrypt;
        private System.Windows.Forms.GroupBox grp_box_Encrypt;
        private System.Windows.Forms.Label lbl_AES_Cryptography;
    }
}
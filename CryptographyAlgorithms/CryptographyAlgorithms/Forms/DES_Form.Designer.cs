namespace CryptographyAlgorithms.Forms
{
    partial class DES_Form
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
            this.grpBox_DES_Encryption = new System.Windows.Forms.GroupBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.txt_Encryp_CipherText = new System.Windows.Forms.TextBox();
            this.lbl_Encryp_CipherText = new System.Windows.Forms.Label();
            this.txt_Encryp_Key = new System.Windows.Forms.TextBox();
            this.lbl_Encryp_Key = new System.Windows.Forms.Label();
            this.txt_Encryp_PlainText = new System.Windows.Forms.TextBox();
            this.lbl_Encryption_PlainText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txt_Decrypt_OriginalText = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_OriginalMessage = new System.Windows.Forms.Label();
            this.txt_Decrypt_key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Decrpyt_CipherText = new System.Windows.Forms.TextBox();
            this.lbl_Decrypt_CipherText = new System.Windows.Forms.Label();
            this.grp_Box_Decryption = new System.Windows.Forms.GroupBox();
            this.grpBox_DES_Encryption.SuspendLayout();
            this.grp_Box_Decryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_DES_Encryption
            // 
            this.grpBox_DES_Encryption.Controls.Add(this.btn_Encrypt);
            this.grpBox_DES_Encryption.Controls.Add(this.txt_Encryp_CipherText);
            this.grpBox_DES_Encryption.Controls.Add(this.lbl_Encryp_CipherText);
            this.grpBox_DES_Encryption.Controls.Add(this.txt_Encryp_Key);
            this.grpBox_DES_Encryption.Controls.Add(this.lbl_Encryp_Key);
            this.grpBox_DES_Encryption.Controls.Add(this.txt_Encryp_PlainText);
            this.grpBox_DES_Encryption.Controls.Add(this.lbl_Encryption_PlainText);
            this.grpBox_DES_Encryption.Location = new System.Drawing.Point(38, 52);
            this.grpBox_DES_Encryption.Name = "grpBox_DES_Encryption";
            this.grpBox_DES_Encryption.Size = new System.Drawing.Size(317, 341);
            this.grpBox_DES_Encryption.TabIndex = 0;
            this.grpBox_DES_Encryption.TabStop = false;
            this.grpBox_DES_Encryption.Text = "Encryption";
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
            // txt_Encryp_CipherText
            // 
            this.txt_Encryp_CipherText.Location = new System.Drawing.Point(23, 230);
            this.txt_Encryp_CipherText.Name = "txt_Encryp_CipherText";
            this.txt_Encryp_CipherText.ReadOnly = true;
            this.txt_Encryp_CipherText.Size = new System.Drawing.Size(262, 23);
            this.txt_Encryp_CipherText.TabIndex = 5;
            // 
            // lbl_Encryp_CipherText
            // 
            this.lbl_Encryp_CipherText.AutoSize = true;
            this.lbl_Encryp_CipherText.Location = new System.Drawing.Point(23, 211);
            this.lbl_Encryp_CipherText.Name = "lbl_Encryp_CipherText";
            this.lbl_Encryp_CipherText.Size = new System.Drawing.Size(65, 15);
            this.lbl_Encryp_CipherText.TabIndex = 4;
            this.lbl_Encryp_CipherText.Text = "Cipher text";
            // 
            // txt_Encryp_Key
            // 
            this.txt_Encryp_Key.Location = new System.Drawing.Point(23, 141);
            this.txt_Encryp_Key.Name = "txt_Encryp_Key";
            this.txt_Encryp_Key.Size = new System.Drawing.Size(262, 23);
            this.txt_Encryp_Key.TabIndex = 3;
            this.txt_Encryp_Key.TextChanged += new System.EventHandler(this.txt_Encryp_Key_TextChanged);
            // 
            // lbl_Encryp_Key
            // 
            this.lbl_Encryp_Key.AutoSize = true;
            this.lbl_Encryp_Key.Location = new System.Drawing.Point(23, 123);
            this.lbl_Encryp_Key.Name = "lbl_Encryp_Key";
            this.lbl_Encryp_Key.Size = new System.Drawing.Size(144, 15);
            this.lbl_Encryp_Key.TabIndex = 2;
            this.lbl_Encryp_Key.Text = "Key ( 16 bit Hexadecimal )";
            // 
            // txt_Encryp_PlainText
            // 
            this.txt_Encryp_PlainText.Location = new System.Drawing.Point(23, 51);
            this.txt_Encryp_PlainText.Name = "txt_Encryp_PlainText";
            this.txt_Encryp_PlainText.Size = new System.Drawing.Size(262, 23);
            this.txt_Encryp_PlainText.TabIndex = 1;
            this.txt_Encryp_PlainText.TextChanged += new System.EventHandler(this.txt_Encryp_PlainText_TextChanged);
            this.txt_Encryp_PlainText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Encryp_PlainText_KeyDown);
            this.txt_Encryp_PlainText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Encryp_PlainText_KeyPress);
            // 
            // lbl_Encryption_PlainText
            // 
            this.lbl_Encryption_PlainText.AutoSize = true;
            this.lbl_Encryption_PlainText.Location = new System.Drawing.Point(23, 33);
            this.lbl_Encryption_PlainText.Name = "lbl_Encryption_PlainText";
            this.lbl_Encryption_PlainText.Size = new System.Drawing.Size(171, 15);
            this.lbl_Encryption_PlainText.TabIndex = 0;
            this.lbl_Encryption_PlainText.Text = "Plain text (16 bit Hexadecimal )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            // lbl_Decrypt_OriginalMessage
            // 
            this.lbl_Decrypt_OriginalMessage.AutoSize = true;
            this.lbl_Decrypt_OriginalMessage.Location = new System.Drawing.Point(23, 211);
            this.lbl_Decrypt_OriginalMessage.Name = "lbl_Decrypt_OriginalMessage";
            this.lbl_Decrypt_OriginalMessage.Size = new System.Drawing.Size(79, 15);
            this.lbl_Decrypt_OriginalMessage.TabIndex = 4;
            this.lbl_Decrypt_OriginalMessage.Text = "Origninal text";
            // 
            // txt_Decrypt_key
            // 
            this.txt_Decrypt_key.Location = new System.Drawing.Point(23, 141);
            this.txt_Decrypt_key.Name = "txt_Decrypt_key";
            this.txt_Decrypt_key.Size = new System.Drawing.Size(262, 23);
            this.txt_Decrypt_key.TabIndex = 3;
            this.txt_Decrypt_key.TextChanged += new System.EventHandler(this.txt_Decrypt_key_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Key ( 16 bit Hexadecimal )";
            // 
            // txt_Decrpyt_CipherText
            // 
            this.txt_Decrpyt_CipherText.Location = new System.Drawing.Point(23, 51);
            this.txt_Decrpyt_CipherText.Name = "txt_Decrpyt_CipherText";
            this.txt_Decrpyt_CipherText.Size = new System.Drawing.Size(262, 23);
            this.txt_Decrpyt_CipherText.TabIndex = 1;
            this.txt_Decrpyt_CipherText.TextChanged += new System.EventHandler(this.txt_Decrpyt_CipherText_TextChanged);
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
            // grp_Box_Decryption
            // 
            this.grp_Box_Decryption.Controls.Add(this.btn_Decrypt);
            this.grp_Box_Decryption.Controls.Add(this.txt_Decrypt_OriginalText);
            this.grp_Box_Decryption.Controls.Add(this.lbl_Decrypt_OriginalMessage);
            this.grp_Box_Decryption.Controls.Add(this.txt_Decrypt_key);
            this.grp_Box_Decryption.Controls.Add(this.label3);
            this.grp_Box_Decryption.Controls.Add(this.txt_Decrpyt_CipherText);
            this.grp_Box_Decryption.Controls.Add(this.lbl_Decrypt_CipherText);
            this.grp_Box_Decryption.Location = new System.Drawing.Point(430, 52);
            this.grp_Box_Decryption.Name = "grp_Box_Decryption";
            this.grp_Box_Decryption.Size = new System.Drawing.Size(317, 341);
            this.grp_Box_Decryption.TabIndex = 0;
            this.grp_Box_Decryption.TabStop = false;
            this.grp_Box_Decryption.Text = "Decryption";
            // 
            // DES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_Box_Decryption);
            this.Controls.Add(this.grpBox_DES_Encryption);
            this.Name = "DES_Form";
            this.Text = "DES_Form";
            this.grpBox_DES_Encryption.ResumeLayout(false);
            this.grpBox_DES_Encryption.PerformLayout();
            this.grp_Box_Decryption.ResumeLayout(false);
            this.grp_Box_Decryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_DES_Encryption;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox txt_Encryp_CipherText;
        private System.Windows.Forms.Label lbl_Encryp_CipherText;
        private System.Windows.Forms.TextBox txt_Encryp_Key;
        private System.Windows.Forms.Label lbl_Encryp_Key;
        private System.Windows.Forms.TextBox txt_Encryp_PlainText;
        private System.Windows.Forms.Label lbl_Encryption_PlainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txt_Decrypt_OriginalText;
        private System.Windows.Forms.Label lbl_Decrypt_OriginalMessage;
        private System.Windows.Forms.TextBox txt_Decrypt_key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Decrpyt_CipherText;
        private System.Windows.Forms.Label lbl_Decrypt_CipherText;
        private System.Windows.Forms.GroupBox grp_Box_Decryption;
    }
}
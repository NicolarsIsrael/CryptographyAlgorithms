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
            this.grpBox_DES_Encryption.SuspendLayout();
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
            // DES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBox_DES_Encryption);
            this.Name = "DES_Form";
            this.Text = "DES_Form";
            this.grpBox_DES_Encryption.ResumeLayout(false);
            this.grpBox_DES_Encryption.PerformLayout();
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
    }
}
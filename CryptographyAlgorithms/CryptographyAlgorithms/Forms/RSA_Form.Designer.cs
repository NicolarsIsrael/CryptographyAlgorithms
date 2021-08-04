namespace CryptographyAlgorithms.Forms
{
    partial class RSA_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rch_Encrypt_PlainText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rch_Encrypt_CipherText = new System.Windows.Forms.RichTextBox();
            this.lbl_Encrypt_PlainText = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rch_Decrypt_CipherText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rch_Decrypt_OriginalText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rch_Encrypt_PlainText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rch_Encrypt_CipherText);
            this.groupBox1.Controls.Add(this.lbl_Encrypt_PlainText);
            this.groupBox1.Controls.Add(this.btn_Encrypt);
            this.groupBox1.Location = new System.Drawing.Point(34, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // rch_Encrypt_PlainText
            // 
            this.rch_Encrypt_PlainText.Location = new System.Drawing.Point(19, 43);
            this.rch_Encrypt_PlainText.Name = "rch_Encrypt_PlainText";
            this.rch_Encrypt_PlainText.Size = new System.Drawing.Size(291, 96);
            this.rch_Encrypt_PlainText.TabIndex = 3;
            this.rch_Encrypt_PlainText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cipher text";
            // 
            // rch_Encrypt_CipherText
            // 
            this.rch_Encrypt_CipherText.Location = new System.Drawing.Point(19, 256);
            this.rch_Encrypt_CipherText.Name = "rch_Encrypt_CipherText";
            this.rch_Encrypt_CipherText.ReadOnly = true;
            this.rch_Encrypt_CipherText.Size = new System.Drawing.Size(291, 96);
            this.rch_Encrypt_CipherText.TabIndex = 3;
            this.rch_Encrypt_CipherText.Text = "";
            // 
            // lbl_Encrypt_PlainText
            // 
            this.lbl_Encrypt_PlainText.AutoSize = true;
            this.lbl_Encrypt_PlainText.Location = new System.Drawing.Point(19, 25);
            this.lbl_Encrypt_PlainText.Name = "lbl_Encrypt_PlainText";
            this.lbl_Encrypt_PlainText.Size = new System.Drawing.Size(56, 15);
            this.lbl_Encrypt_PlainText.TabIndex = 2;
            this.lbl_Encrypt_PlainText.Text = "Plain text";
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(19, 145);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 1;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cipher text";
            // 
            // rch_Decrypt_CipherText
            // 
            this.rch_Decrypt_CipherText.Location = new System.Drawing.Point(19, 43);
            this.rch_Decrypt_CipherText.Name = "rch_Decrypt_CipherText";
            this.rch_Decrypt_CipherText.Size = new System.Drawing.Size(291, 96);
            this.rch_Decrypt_CipherText.TabIndex = 3;
            this.rch_Decrypt_CipherText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Original message";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(19, 145);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 1;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rch_Decrypt_OriginalText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rch_Decrypt_CipherText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Decrypt);
            this.groupBox2.Location = new System.Drawing.Point(426, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 378);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption";
            // 
            // rch_Decrypt_OriginalText
            // 
            this.rch_Decrypt_OriginalText.Location = new System.Drawing.Point(19, 256);
            this.rch_Decrypt_OriginalText.Name = "rch_Decrypt_OriginalText";
            this.rch_Decrypt_OriginalText.ReadOnly = true;
            this.rch_Decrypt_OriginalText.Size = new System.Drawing.Size(291, 96);
            this.rch_Decrypt_OriginalText.TabIndex = 3;
            this.rch_Decrypt_OriginalText.Text = "";
            // 
            // RSA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RSA_Form";
            this.Text = "RSA_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rch_Encrypt_CipherText;
        private System.Windows.Forms.Label lbl_Encrypt_PlainText;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rch_Decrypt_CipherText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rch_Encrypt_PlainText;
        private System.Windows.Forms.RichTextBox rch_Decrypt_OriginalText;
    }
}
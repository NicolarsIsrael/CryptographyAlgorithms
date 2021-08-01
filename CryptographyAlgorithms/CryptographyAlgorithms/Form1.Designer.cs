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
            this.btn_DesCryptography.Location = new System.Drawing.Point(266, 71);
            this.btn_DesCryptography.Name = "btn_DesCryptography";
            this.btn_DesCryptography.Size = new System.Drawing.Size(241, 23);
            this.btn_DesCryptography.TabIndex = 1;
            this.btn_DesCryptography.Text = "DES Cryptography";
            this.btn_DesCryptography.UseVisualStyleBackColor = true;
            this.btn_DesCryptography.Click += new System.EventHandler(this.btn_DesCryptography_Click);
            // 
            // btn_AES_Cryptography
            // 
            this.btn_AES_Cryptography.Location = new System.Drawing.Point(266, 101);
            this.btn_AES_Cryptography.Name = "btn_AES_Cryptography";
            this.btn_AES_Cryptography.Size = new System.Drawing.Size(241, 23);
            this.btn_AES_Cryptography.TabIndex = 2;
            this.btn_AES_Cryptography.Text = "AES Cryptography";
            this.btn_AES_Cryptography.UseVisualStyleBackColor = true;
            this.btn_AES_Cryptography.Click += new System.EventHandler(this.btn_AES_Cryptography_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AES_Cryptography);
            this.Controls.Add(this.btn_DesCryptography);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DesCryptography;
        private System.Windows.Forms.Button btn_AES_Cryptography;
    }
}


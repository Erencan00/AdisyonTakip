﻿
namespace AdisyonTakip
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kulkod = new System.Windows.Forms.TextBox();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lbl_kul_Adi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // txt_kulkod
            // 
            this.txt_kulkod.Location = new System.Drawing.Point(132, 33);
            this.txt_kulkod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kulkod.Name = "txt_kulkod";
            this.txt_kulkod.Size = new System.Drawing.Size(132, 22);
            this.txt_kulkod.TabIndex = 3;
            this.txt_kulkod.Text = "0";
            this.txt_kulkod.TextChanged += new System.EventHandler(this.txt_kulkod_TextChanged);
            // 
            // txt_psw
            // 
            this.txt_psw.Location = new System.Drawing.Point(132, 65);
            this.txt_psw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.PasswordChar = '*';
            this.txt_psw.Size = new System.Drawing.Size(132, 22);
            this.txt_psw.TabIndex = 4;
            this.txt_psw.Text = "0";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(232, 116);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(223, 28);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.Location = new System.Drawing.Point(16, 116);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(208, 28);
            this.btn_cikis.TabIndex = 7;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lbl_kul_Adi
            // 
            this.lbl_kul_Adi.AutoSize = true;
            this.lbl_kul_Adi.Location = new System.Drawing.Point(299, 39);
            this.lbl_kul_Adi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kul_Adi.Name = "lbl_kul_Adi";
            this.lbl_kul_Adi.Size = new System.Drawing.Size(0, 16);
            this.lbl_kul_Adi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adı";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cikis;
            this.ClientSize = new System.Drawing.Size(471, 160);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_kul_Adi);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.txt_kulkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kulkod;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_kul_Adi;
        private System.Windows.Forms.Label label3;
    }
}
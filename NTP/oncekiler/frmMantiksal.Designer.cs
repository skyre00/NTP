namespace NTP
{
    partial class frmMantiksal
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
            this.btGiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.cbGoster = new System.Windows.Forms.CheckBox();
            this.btKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGiris
            // 
            this.btGiris.Location = new System.Drawing.Point(152, 82);
            this.btGiris.Name = "btGiris";
            this.btGiris.Size = new System.Drawing.Size(153, 35);
            this.btGiris.TabIndex = 0;
            this.btGiris.Text = "Uçur bizi Recai!...)";
            this.btGiris.UseVisualStyleBackColor = true;
            this.btGiris.Click += new System.EventHandler(this.btGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btKapat);
            this.groupBox1.Controls.Add(this.cbGoster);
            this.groupBox1.Controls.Add(this.btGiris);
            this.groupBox1.Controls.Add(this.tbSifre);
            this.groupBox1.Controls.Add(this.tbKullaniciAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileriniz";
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.Location = new System.Drawing.Point(127, 15);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.tbKullaniciAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifreniz:";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(127, 44);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '*';
            this.tbSifre.Size = new System.Drawing.Size(100, 22);
            this.tbSifre.TabIndex = 5;
            // 
            // cbGoster
            // 
            this.cbGoster.AutoSize = true;
            this.cbGoster.Location = new System.Drawing.Point(246, 44);
            this.cbGoster.Name = "cbGoster";
            this.cbGoster.Size = new System.Drawing.Size(73, 21);
            this.cbGoster.TabIndex = 6;
            this.cbGoster.Text = "Göster";
            this.cbGoster.UseVisualStyleBackColor = true;
            this.cbGoster.CheckedChanged += new System.EventHandler(this.cbGoster_CheckedChanged);
            // 
            // btKapat
            // 
            this.btKapat.Location = new System.Drawing.Point(36, 82);
            this.btKapat.Name = "btKapat";
            this.btKapat.Size = new System.Drawing.Size(85, 35);
            this.btKapat.TabIndex = 7;
            this.btKapat.Text = "Kapat";
            this.btKapat.UseVisualStyleBackColor = true;
            this.btKapat.Click += new System.EventHandler(this.btKapat_Click);
            // 
            // frmMantiksal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 181);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMantiksal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantıksal Operatör";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.CheckBox cbGoster;
        private System.Windows.Forms.Button btKapat;
    }
}
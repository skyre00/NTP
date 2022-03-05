namespace NTP
{
    partial class frmClass1
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
            this.bt1 = new System.Windows.Forms.Button();
            this.btOrnek = new System.Windows.Forms.Button();
            this.btDikdortgen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKenar1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKenar2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCevresi = new System.Windows.Forms.Label();
            this.lbAlani = new System.Windows.Forms.Label();
            this.btHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSonDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(44, 42);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(121, 67);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "İnsan 1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btOrnek
            // 
            this.btOrnek.Location = new System.Drawing.Point(262, 42);
            this.btOrnek.Name = "btOrnek";
            this.btOrnek.Size = new System.Drawing.Size(105, 67);
            this.btOrnek.TabIndex = 1;
            this.btOrnek.Text = "Örnek";
            this.btOrnek.UseVisualStyleBackColor = true;
            this.btOrnek.Click += new System.EventHandler(this.btOrnek_Click);
            // 
            // btDikdortgen
            // 
            this.btDikdortgen.Location = new System.Drawing.Point(395, 42);
            this.btDikdortgen.Name = "btDikdortgen";
            this.btDikdortgen.Size = new System.Drawing.Size(165, 67);
            this.btDikdortgen.TabIndex = 2;
            this.btDikdortgen.Text = "Dikdörtgen örneği";
            this.btDikdortgen.UseVisualStyleBackColor = true;
            this.btDikdortgen.Click += new System.EventHandler(this.btDikdortgen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. kenar";
            // 
            // tbKenar1
            // 
            this.tbKenar1.Location = new System.Drawing.Point(179, 134);
            this.tbKenar1.Name = "tbKenar1";
            this.tbKenar1.Size = new System.Drawing.Size(100, 22);
            this.tbKenar1.TabIndex = 4;
            this.tbKenar1.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "2. kenar";
            // 
            // tbKenar2
            // 
            this.tbKenar2.Location = new System.Drawing.Point(179, 162);
            this.tbKenar2.Name = "tbKenar2";
            this.tbKenar2.Size = new System.Drawing.Size(100, 22);
            this.tbKenar2.TabIndex = 6;
            this.tbKenar2.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Çevresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alanı";
            // 
            // lbCevresi
            // 
            this.lbCevresi.AutoSize = true;
            this.lbCevresi.Location = new System.Drawing.Point(178, 201);
            this.lbCevresi.Name = "lbCevresi";
            this.lbCevresi.Size = new System.Drawing.Size(0, 17);
            this.lbCevresi.TabIndex = 9;
            // 
            // lbAlani
            // 
            this.lbAlani.AutoSize = true;
            this.lbAlani.Location = new System.Drawing.Point(176, 231);
            this.lbAlani.Name = "lbAlani";
            this.lbAlani.Size = new System.Drawing.Size(0, 17);
            this.lbAlani.TabIndex = 10;
            // 
            // btHesapla
            // 
            this.btHesapla.Location = new System.Drawing.Point(285, 134);
            this.btHesapla.Name = "btHesapla";
            this.btHesapla.Size = new System.Drawing.Size(117, 114);
            this.btHesapla.TabIndex = 11;
            this.btHesapla.Text = "Hesapla";
            this.btHesapla.UseVisualStyleBackColor = true;
            this.btHesapla.Click += new System.EventHandler(this.btHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Son durum";
            // 
            // lbSonDurum
            // 
            this.lbSonDurum.AutoSize = true;
            this.lbSonDurum.Location = new System.Drawing.Point(178, 260);
            this.lbSonDurum.Name = "lbSonDurum";
            this.lbSonDurum.Size = new System.Drawing.Size(0, 17);
            this.lbSonDurum.TabIndex = 13;
            // 
            // frmClass1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 325);
            this.Controls.Add(this.lbSonDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btHesapla);
            this.Controls.Add(this.lbAlani);
            this.Controls.Add(this.lbCevresi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKenar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKenar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDikdortgen);
            this.Controls.Add(this.btOrnek);
            this.Controls.Add(this.bt1);
            this.Name = "frmClass1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClass1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btOrnek;
        private System.Windows.Forms.Button btDikdortgen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKenar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKenar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCevresi;
        private System.Windows.Forms.Label lbAlani;
        private System.Windows.Forms.Button btHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSonDurum;
    }
}
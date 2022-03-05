namespace NTP
{
    partial class frmDizi1
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
            this.lbGirilenDeger = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKacSayi = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbIfade = new System.Windows.Forms.TextBox();
            this.btHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGirilenDeger
            // 
            this.lbGirilenDeger.AutoSize = true;
            this.lbGirilenDeger.Location = new System.Drawing.Point(37, 217);
            this.lbGirilenDeger.Name = "lbGirilenDeger";
            this.lbGirilenDeger.Size = new System.Drawing.Size(47, 17);
            this.lbGirilenDeger.TabIndex = 13;
            this.lbGirilenDeger.Text = "Değer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "İfade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kaç tane isim gireceksin";
            // 
            // tbKacSayi
            // 
            this.tbKacSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKacSayi.Location = new System.Drawing.Point(218, 20);
            this.tbKacSayi.Name = "tbKacSayi";
            this.tbKacSayi.Size = new System.Drawing.Size(100, 30);
            this.tbKacSayi.TabIndex = 10;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(215, 160);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(48, 17);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "Sonuc";
            // 
            // tbIfade
            // 
            this.tbIfade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbIfade.Location = new System.Drawing.Point(218, 56);
            this.tbIfade.Name = "tbIfade";
            this.tbIfade.Size = new System.Drawing.Size(100, 30);
            this.tbIfade.TabIndex = 8;
            // 
            // btHesapla
            // 
            this.btHesapla.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btHesapla.Location = new System.Drawing.Point(218, 92);
            this.btHesapla.Name = "btHesapla";
            this.btHesapla.Size = new System.Drawing.Size(113, 51);
            this.btHesapla.TabIndex = 7;
            this.btHesapla.Text = "Hesapla";
            this.btHesapla.UseVisualStyleBackColor = true;
            this.btHesapla.Click += new System.EventHandler(this.btHesapla_Click);
            // 
            // frmDizi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 259);
            this.Controls.Add(this.lbGirilenDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKacSayi);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbIfade);
            this.Controls.Add(this.btHesapla);
            this.Name = "frmDizi1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDizi1";
            this.Load += new System.EventHandler(this.frmDizi1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGirilenDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKacSayi;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbIfade;
        private System.Windows.Forms.Button btHesapla;
    }
}
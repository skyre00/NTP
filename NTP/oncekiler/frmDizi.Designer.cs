namespace NTP
{
    partial class frmDizi
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
            this.btHesapla = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbKacSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGirilenDeger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btHesapla
            // 
            this.btHesapla.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btHesapla.Location = new System.Drawing.Point(193, 84);
            this.btHesapla.Name = "btHesapla";
            this.btHesapla.Size = new System.Drawing.Size(113, 51);
            this.btHesapla.TabIndex = 0;
            this.btHesapla.Text = "Hesapla";
            this.btHesapla.UseVisualStyleBackColor = true;
            this.btHesapla.Click += new System.EventHandler(this.btHesapla_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb1.Location = new System.Drawing.Point(193, 48);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 30);
            this.tb1.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(190, 152);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(48, 17);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Sonuc";
            // 
            // tbKacSayi
            // 
            this.tbKacSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKacSayi.Location = new System.Drawing.Point(193, 12);
            this.tbKacSayi.Name = "tbKacSayi";
            this.tbKacSayi.Size = new System.Drawing.Size(100, 30);
            this.tbKacSayi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaç tane sayı gireceksin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Değer";
            // 
            // lbGirilenDeger
            // 
            this.lbGirilenDeger.AutoSize = true;
            this.lbGirilenDeger.Location = new System.Drawing.Point(12, 209);
            this.lbGirilenDeger.Name = "lbGirilenDeger";
            this.lbGirilenDeger.Size = new System.Drawing.Size(47, 17);
            this.lbGirilenDeger.TabIndex = 6;
            this.lbGirilenDeger.Text = "Değer";
            // 
            // frmDizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 253);
            this.Controls.Add(this.lbGirilenDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKacSayi);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btHesapla);
            this.Name = "frmDizi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDizi";
            this.Load += new System.EventHandler(this.frmDizi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHesapla;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbKacSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGirilenDeger;
    }
}
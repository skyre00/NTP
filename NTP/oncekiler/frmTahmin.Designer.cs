namespace NTP
{
    partial class frmTahmin
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
            this.btTahminEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBKacaKadar = new System.Windows.Forms.TextBox();
            this.tbTahmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.btSayiUret = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btTahminHakkiniz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTahminEt
            // 
            this.btTahminEt.Location = new System.Drawing.Point(47, 188);
            this.btTahminEt.Name = "btTahminEt";
            this.btTahminEt.Size = new System.Drawing.Size(155, 46);
            this.btTahminEt.TabIndex = 0;
            this.btTahminEt.Text = "Tahmin Et";
            this.btTahminEt.UseVisualStyleBackColor = false;
            this.btTahminEt.Click += new System.EventHandler(this.btTahminEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaça Kadar";
            // 
            // TBKacaKadar
            // 
            this.TBKacaKadar.Location = new System.Drawing.Point(152, 66);
            this.TBKacaKadar.Name = "TBKacaKadar";
            this.TBKacaKadar.Size = new System.Drawing.Size(100, 22);
            this.TBKacaKadar.TabIndex = 2;
            // 
            // tbTahmin
            // 
            this.tbTahmin.Location = new System.Drawing.Point(152, 108);
            this.tbTahmin.Name = "tbTahmin";
            this.tbTahmin.Size = new System.Drawing.Size(100, 22);
            this.tbTahmin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tahmininiz";
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(104, 137);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 17);
            this.lbSonuc.TabIndex = 5;
            // 
            // btSayiUret
            // 
            this.btSayiUret.Location = new System.Drawing.Point(273, 66);
            this.btSayiUret.Name = "btSayiUret";
            this.btSayiUret.Size = new System.Drawing.Size(162, 30);
            this.btSayiUret.TabIndex = 6;
            this.btSayiUret.Text = "Sayı üret";
            this.btSayiUret.UseVisualStyleBackColor = false;
            this.btSayiUret.Click += new System.EventHandler(this.btSayiUret_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tahmin hakkınız?";
            // 
            // btTahminHakkiniz
            // 
            this.btTahminHakkiniz.Location = new System.Drawing.Point(167, 25);
            this.btTahminHakkiniz.Name = "btTahminHakkiniz";
            this.btTahminHakkiniz.Size = new System.Drawing.Size(100, 22);
            this.btTahminHakkiniz.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Resetle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btTahminHakkiniz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSayiUret);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.tbTahmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBKacaKadar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTahminEt);
            this.Name = "frmTahmin";
            this.Text = "frmTahmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTahminEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBKacaKadar;
        private System.Windows.Forms.TextBox tbTahmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.Button btSayiUret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btTahminHakkiniz;
        private System.Windows.Forms.Button button1;
    }
}
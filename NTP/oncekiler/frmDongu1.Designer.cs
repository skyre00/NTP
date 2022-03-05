namespace NTP
{
    partial class frmDongu1
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
            this.lb1 = new System.Windows.Forms.Label();
            this.btSay = new System.Windows.Forms.Button();
            this.btSifirla = new System.Windows.Forms.Button();
            this.tb100 = new System.Windows.Forms.TextBox();
            this.tbBaslangic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdimSayisi = new System.Windows.Forms.TextBox();
            this.tbBitis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAtesle = new System.Windows.Forms.Button();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(113, 103);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 17);
            this.lb1.TabIndex = 3;
            // 
            // btSay
            // 
            this.btSay.Location = new System.Drawing.Point(28, 29);
            this.btSay.Name = "btSay";
            this.btSay.Size = new System.Drawing.Size(221, 56);
            this.btSay.TabIndex = 2;
            this.btSay.Text = "100\'e kadar 1\'er 1\'er arttır";
            this.btSay.UseVisualStyleBackColor = true;
            this.btSay.Click += new System.EventHandler(this.btSay_Click);
            // 
            // btSifirla
            // 
            this.btSifirla.Location = new System.Drawing.Point(12, 498);
            this.btSifirla.Name = "btSifirla";
            this.btSifirla.Size = new System.Drawing.Size(237, 56);
            this.btSifirla.TabIndex = 8;
            this.btSifirla.Text = "Sıfırla";
            this.btSifirla.UseVisualStyleBackColor = true;
            this.btSifirla.Click += new System.EventHandler(this.btSifirla_Click);
            // 
            // tb100
            // 
            this.tb100.Enabled = false;
            this.tb100.Location = new System.Drawing.Point(28, 91);
            this.tb100.Multiline = true;
            this.tb100.Name = "tb100";
            this.tb100.ReadOnly = true;
            this.tb100.Size = new System.Drawing.Size(221, 241);
            this.tb100.TabIndex = 9;
            // 
            // tbBaslangic
            // 
            this.tbBaslangic.Location = new System.Drawing.Point(179, 348);
            this.tbBaslangic.Name = "tbBaslangic";
            this.tbBaslangic.Size = new System.Drawing.Size(70, 22);
            this.tbBaslangic.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kaçtan başlasın";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kaçar kaçar devam etsin";
            // 
            // tbAdimSayisi
            // 
            this.tbAdimSayisi.Location = new System.Drawing.Point(179, 376);
            this.tbAdimSayisi.Name = "tbAdimSayisi";
            this.tbAdimSayisi.Size = new System.Drawing.Size(70, 22);
            this.tbAdimSayisi.TabIndex = 12;
            // 
            // tbBitis
            // 
            this.tbBitis.Location = new System.Drawing.Point(179, 404);
            this.tbBitis.Name = "tbBitis";
            this.tbBitis.Size = new System.Drawing.Size(70, 22);
            this.tbBitis.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kaçta bitsin";
            // 
            // btAtesle
            // 
            this.btAtesle.Location = new System.Drawing.Point(12, 438);
            this.btAtesle.Name = "btAtesle";
            this.btAtesle.Size = new System.Drawing.Size(237, 54);
            this.btAtesle.TabIndex = 16;
            this.btAtesle.Text = "Ateşle";
            this.btAtesle.UseVisualStyleBackColor = true;
            this.btAtesle.Click += new System.EventHandler(this.btAtesle_Click);
            // 
            // tbSonuc
            // 
            this.tbSonuc.Enabled = false;
            this.tbSonuc.Location = new System.Drawing.Point(255, 29);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(692, 604);
            this.tbSonuc.TabIndex = 17;
            // 
            // frmDongu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 695);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.btAtesle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAdimSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBaslangic);
            this.Controls.Add(this.tb100);
            this.Controls.Add(this.btSifirla);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btSay);
            this.Name = "frmDongu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döngü 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btSay;
        private System.Windows.Forms.Button btSifirla;
        private System.Windows.Forms.TextBox tb100;
        private System.Windows.Forms.TextBox tbBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdimSayisi;
        private System.Windows.Forms.TextBox tbBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAtesle;
        private System.Windows.Forms.TextBox tbSonuc;
    }
}
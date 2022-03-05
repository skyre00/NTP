namespace NTP
{
    partial class frm1Bolumebilme
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
            this.bt17 = new System.Windows.Forms.Button();
            this.tb17 = new System.Windows.Forms.TextBox();
            this.tbBolen = new System.Windows.Forms.TextBox();
            this.tbKacaKadar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt17
            // 
            this.bt17.Location = new System.Drawing.Point(44, 30);
            this.bt17.Name = "bt17";
            this.bt17.Size = new System.Drawing.Size(157, 98);
            this.bt17.TabIndex = 0;
            this.bt17.Text = "17\'ye bölünebilme";
            this.bt17.UseVisualStyleBackColor = true;
            this.bt17.Click += new System.EventHandler(this.bt17_Click);
            // 
            // tb17
            // 
            this.tb17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tb17.Location = new System.Drawing.Point(130, 210);
            this.tb17.Multiline = true;
            this.tb17.Name = "tb17";
            this.tb17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb17.Size = new System.Drawing.Size(663, 322);
            this.tb17.TabIndex = 2;
            // 
            // tbBolen
            // 
            this.tbBolen.Location = new System.Drawing.Point(472, 89);
            this.tbBolen.Name = "tbBolen";
            this.tbBolen.Size = new System.Drawing.Size(100, 23);
            this.tbBolen.TabIndex = 3;
            // 
            // tbKacaKadar
            // 
            this.tbKacaKadar.Location = new System.Drawing.Point(472, 131);
            this.tbKacaKadar.Name = "tbKacaKadar";
            this.tbKacaKadar.Size = new System.Drawing.Size(100, 23);
            this.tbKacaKadar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bölen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kaça kadar";
            // 
            // btHesapla
            // 
            this.btHesapla.Location = new System.Drawing.Point(588, 89);
            this.btHesapla.Name = "btHesapla";
            this.btHesapla.Size = new System.Drawing.Size(159, 65);
            this.btHesapla.TabIndex = 7;
            this.btHesapla.Text = "Hesapla";
            this.btHesapla.UseVisualStyleBackColor = true;
            this.btHesapla.Click += new System.EventHandler(this.btHesapla_Click);
            // 
            // frm1Bolumebilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 818);
            this.Controls.Add(this.btHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKacaKadar);
            this.Controls.Add(this.tbBolen);
            this.Controls.Add(this.tb17);
            this.Controls.Add(this.bt17);
            this.Name = "frm1Bolumebilme";
            this.Text = "frm1Bolumebilme";
            this.Load += new System.EventHandler(this.frm1Bolumebilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt17;
        private System.Windows.Forms.TextBox tb17;
        private System.Windows.Forms.TextBox tbBolen;
        private System.Windows.Forms.TextBox tbKacaKadar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btHesapla;
    }
}
namespace NTP
{
    partial class aritmetik
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
            this.tbDeger = new System.Windows.Forms.TextBox();
            this.btModAl = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.tbKontrol = new System.Windows.Forms.TextBox();
            this.btCevir = new System.Windows.Forms.Button();
            this.btIslemOnceligi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDeger
            // 
            this.tbDeger.Location = new System.Drawing.Point(75, 41);
            this.tbDeger.Name = "tbDeger";
            this.tbDeger.Size = new System.Drawing.Size(100, 22);
            this.tbDeger.TabIndex = 0;
            // 
            // btModAl
            // 
            this.btModAl.Location = new System.Drawing.Point(75, 69);
            this.btModAl.Name = "btModAl";
            this.btModAl.Size = new System.Drawing.Size(75, 23);
            this.btModAl.TabIndex = 1;
            this.btModAl.Text = "Mod Al (%)";
            this.btModAl.UseVisualStyleBackColor = true;
            this.btModAl.Click += new System.EventHandler(this.btModAl_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(223, 105);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 17);
            this.lbSonuc.TabIndex = 2;
            // 
            // tbKontrol
            // 
            this.tbKontrol.Location = new System.Drawing.Point(311, 41);
            this.tbKontrol.Name = "tbKontrol";
            this.tbKontrol.Size = new System.Drawing.Size(100, 22);
            this.tbKontrol.TabIndex = 3;
            this.tbKontrol.Text = "Buradayım";
            // 
            // btCevir
            // 
            this.btCevir.Location = new System.Drawing.Point(311, 68);
            this.btCevir.Name = "btCevir";
            this.btCevir.Size = new System.Drawing.Size(75, 23);
            this.btCevir.TabIndex = 4;
            this.btCevir.Text = "Çevir";
            this.btCevir.UseVisualStyleBackColor = true;
            this.btCevir.Click += new System.EventHandler(this.btCevir_Click);
            // 
            // btIslemOnceligi
            // 
            this.btIslemOnceligi.Location = new System.Drawing.Point(468, 68);
            this.btIslemOnceligi.Name = "btIslemOnceligi";
            this.btIslemOnceligi.Size = new System.Drawing.Size(100, 77);
            this.btIslemOnceligi.TabIndex = 5;
            this.btIslemOnceligi.Text = "İşlem Önceliği";
            this.btIslemOnceligi.UseVisualStyleBackColor = true;
            this.btIslemOnceligi.Click += new System.EventHandler(this.btIslemOnceligi_Click);
            // 
            // aritmetik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 316);
            this.Controls.Add(this.btIslemOnceligi);
            this.Controls.Add(this.btCevir);
            this.Controls.Add(this.tbKontrol);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btModAl);
            this.Controls.Add(this.tbDeger);
            this.Name = "aritmetik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aritmetik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDeger;
        private System.Windows.Forms.Button btModAl;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.TextBox tbKontrol;
        private System.Windows.Forms.Button btCevir;
        private System.Windows.Forms.Button btIslemOnceligi;
    }
}
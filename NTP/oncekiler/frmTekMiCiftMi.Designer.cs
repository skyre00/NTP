namespace NTP
{
    partial class frmTekMiCiftMi
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
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.btHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayınız?";
            // 
            // tbSayi
            // 
            this.tbSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSayi.Location = new System.Drawing.Point(83, 68);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(100, 47);
            this.tbSayi.TabIndex = 1;
            // 
            // btHesapla
            // 
            this.btHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btHesapla.Location = new System.Drawing.Point(40, 131);
            this.btHesapla.Name = "btHesapla";
            this.btHesapla.Size = new System.Drawing.Size(187, 66);
            this.btHesapla.TabIndex = 2;
            this.btHesapla.Text = "Hesapla";
            this.btHesapla.UseVisualStyleBackColor = true;
            this.btHesapla.Click += new System.EventHandler(this.btHesapla_Click);
            // 
            // frmTekMiCiftMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btHesapla);
            this.Controls.Add(this.tbSayi);
            this.Controls.Add(this.label1);
            this.Name = "frmTekMiCiftMi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tek mi çift mi?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.Button btHesapla;
    }
}
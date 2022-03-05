namespace NTP
{
    partial class frmCarpim1
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
            this.tbTablo = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btCarpim = new System.Windows.Forms.Button();
            this.btIcIceTablosu = new System.Windows.Forms.Button();
            this.tbCarpimTablosu = new System.Windows.Forms.TextBox();
            this.btCarpimTablosu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTablo
            // 
            this.tbTablo.Enabled = false;
            this.tbTablo.Location = new System.Drawing.Point(30, 97);
            this.tbTablo.Multiline = true;
            this.tbTablo.Name = "tbTablo";
            this.tbTablo.ReadOnly = true;
            this.tbTablo.Size = new System.Drawing.Size(221, 241);
            this.tbTablo.TabIndex = 12;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(115, 109);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 17);
            this.lb1.TabIndex = 11;
            // 
            // btCarpim
            // 
            this.btCarpim.Location = new System.Drawing.Point(30, 35);
            this.btCarpim.Name = "btCarpim";
            this.btCarpim.Size = new System.Drawing.Size(221, 56);
            this.btCarpim.TabIndex = 10;
            this.btCarpim.Text = "Mini çarpım tablosu";
            this.btCarpim.UseVisualStyleBackColor = true;
            this.btCarpim.Click += new System.EventHandler(this.btCarpim_Click);
            // 
            // btIcIceTablosu
            // 
            this.btIcIceTablosu.Location = new System.Drawing.Point(315, 35);
            this.btIcIceTablosu.Name = "btIcIceTablosu";
            this.btIcIceTablosu.Size = new System.Drawing.Size(221, 56);
            this.btIcIceTablosu.TabIndex = 13;
            this.btIcIceTablosu.Text = "İç içe döngü";
            this.btIcIceTablosu.UseVisualStyleBackColor = true;
            this.btIcIceTablosu.Click += new System.EventHandler(this.btIcIce_Click);
            // 
            // tbCarpimTablosu
            // 
            this.tbCarpimTablosu.Location = new System.Drawing.Point(315, 97);
            this.tbCarpimTablosu.Multiline = true;
            this.tbCarpimTablosu.Name = "tbCarpimTablosu";
            this.tbCarpimTablosu.ReadOnly = true;
            this.tbCarpimTablosu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCarpimTablosu.Size = new System.Drawing.Size(702, 677);
            this.tbCarpimTablosu.TabIndex = 14;
            // 
            // btCarpimTablosu
            // 
            this.btCarpimTablosu.Location = new System.Drawing.Point(30, 351);
            this.btCarpimTablosu.Name = "btCarpimTablosu";
            this.btCarpimTablosu.Size = new System.Drawing.Size(221, 56);
            this.btCarpimTablosu.TabIndex = 16;
            this.btCarpimTablosu.Text = "Mini çarpım tablosu";
            this.btCarpimTablosu.UseVisualStyleBackColor = true;
            this.btCarpimTablosu.Click += new System.EventHandler(this.btCarpimTablosu_Click);
            // 
            // frmCarpim1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 786);
            this.Controls.Add(this.btCarpimTablosu);
            this.Controls.Add(this.tbCarpimTablosu);
            this.Controls.Add(this.btIcIceTablosu);
            this.Controls.Add(this.tbTablo);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btCarpim);
            this.Name = "frmCarpim1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çarpım Tablosu 1";
            this.Load += new System.EventHandler(this.frmCarpim1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTablo;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btCarpim;
        private System.Windows.Forms.Button btIcIceTablosu;
        private System.Windows.Forms.TextBox tbCarpimTablosu;
        private System.Windows.Forms.Button btCarpimTablosu;
    }
}
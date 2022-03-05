namespace NTP
{
    partial class frmSayiTahmin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKacHakIstiyorsun = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTahmininiz = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbGecenSure = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btUret = new System.Windows.Forms.Button();
            this.pbTamam = new System.Windows.Forms.PictureBox();
            this.pbYukari = new System.Windows.Forms.PictureBox();
            this.pbAsagi = new System.Windows.Forms.PictureBox();
            this.lbTahminler = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYukari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsagi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç hak istiyorsun";
            // 
            // cbKacHakIstiyorsun
            // 
            this.cbKacHakIstiyorsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKacHakIstiyorsun.FormattingEnabled = true;
            this.cbKacHakIstiyorsun.Location = new System.Drawing.Point(267, 42);
            this.cbKacHakIstiyorsun.Name = "cbKacHakIstiyorsun";
            this.cbKacHakIstiyorsun.Size = new System.Drawing.Size(73, 33);
            this.cbKacHakIstiyorsun.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btUret);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(29, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kaç ile kaç arasında olsun";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(20, 43);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(48, 30);
            this.tbMin.TabIndex = 0;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(116, 43);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(48, 30);
            this.tbMax.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tahmininiz:";
            // 
            // tbTahmininiz
            // 
            this.tbTahmininiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTahmininiz.Location = new System.Drawing.Point(164, 228);
            this.tbTahmininiz.Name = "tbTahmininiz";
            this.tbTahmininiz.Size = new System.Drawing.Size(59, 30);
            this.tbTahmininiz.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbGecenSure});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbGecenSure
            // 
            this.lbGecenSure.Name = "lbGecenSure";
            this.lbGecenSure.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btUret
            // 
            this.btUret.Location = new System.Drawing.Point(187, 39);
            this.btUret.Name = "btUret";
            this.btUret.Size = new System.Drawing.Size(103, 39);
            this.btUret.TabIndex = 3;
            this.btUret.Text = "Üret";
            this.btUret.UseVisualStyleBackColor = true;
            this.btUret.Click += new System.EventHandler(this.btUret_Click);
            // 
            // pbTamam
            // 
            this.pbTamam.Image = global::NTP.Properties.Resources.baseline_emoji_emotions_black_24dp;
            this.pbTamam.Location = new System.Drawing.Point(249, 217);
            this.pbTamam.Name = "pbTamam";
            this.pbTamam.Size = new System.Drawing.Size(50, 50);
            this.pbTamam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTamam.TabIndex = 7;
            this.pbTamam.TabStop = false;
            this.pbTamam.Visible = false;
            // 
            // pbYukari
            // 
            this.pbYukari.Image = global::NTP.Properties.Resources.baseline_thumb_up_alt_black_24dp;
            this.pbYukari.Location = new System.Drawing.Point(249, 217);
            this.pbYukari.Name = "pbYukari";
            this.pbYukari.Size = new System.Drawing.Size(50, 50);
            this.pbYukari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYukari.TabIndex = 6;
            this.pbYukari.TabStop = false;
            this.pbYukari.Visible = false;
            // 
            // pbAsagi
            // 
            this.pbAsagi.Image = global::NTP.Properties.Resources.baseline_thumb_down_alt_black_24dp;
            this.pbAsagi.Location = new System.Drawing.Point(249, 217);
            this.pbAsagi.Name = "pbAsagi";
            this.pbAsagi.Size = new System.Drawing.Size(50, 50);
            this.pbAsagi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAsagi.TabIndex = 0;
            this.pbAsagi.TabStop = false;
            this.pbAsagi.Visible = false;
            // 
            // lbTahminler
            // 
            this.lbTahminler.AutoSize = true;
            this.lbTahminler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTahminler.Location = new System.Drawing.Point(24, 279);
            this.lbTahminler.Name = "lbTahminler";
            this.lbTahminler.Size = new System.Drawing.Size(108, 25);
            this.lbTahminler.TabIndex = 8;
            this.lbTahminler.Text = "Tahminler";
            // 
            // frmSayiTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 353);
            this.Controls.Add(this.lbTahminler);
            this.Controls.Add(this.pbTamam);
            this.Controls.Add(this.pbYukari);
            this.Controls.Add(this.pbAsagi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbTahmininiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbKacHakIstiyorsun);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmSayiTahmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Tahmini Oyununa Hoş Geldiniz";
            this.Load += new System.EventHandler(this.frmSayiTahmin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSayiTahmin_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYukari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsagi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKacHakIstiyorsun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTahmininiz;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbGecenSure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btUret;
        private System.Windows.Forms.PictureBox pbAsagi;
        private System.Windows.Forms.PictureBox pbYukari;
        private System.Windows.Forms.PictureBox pbTamam;
        private System.Windows.Forms.Label lbTahminler;
    }
}
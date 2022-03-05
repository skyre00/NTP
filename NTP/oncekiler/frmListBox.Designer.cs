namespace NTP
{
    partial class frmListBox
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
            this.btEkle = new System.Windows.Forms.Button();
            this.lb20 = new System.Windows.Forms.ListBox();
            this.btResetle = new System.Windows.Forms.Button();
            this.lbCift = new System.Windows.Forms.ListBox();
            this.lbTek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDagit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEkle
            // 
            this.btEkle.Location = new System.Drawing.Point(45, 77);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(129, 37);
            this.btEkle.TabIndex = 0;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // lb20
            // 
            this.lb20.FormattingEnabled = true;
            this.lb20.ItemHeight = 16;
            this.lb20.Location = new System.Drawing.Point(24, 151);
            this.lb20.Name = "lb20";
            this.lb20.Size = new System.Drawing.Size(194, 388);
            this.lb20.TabIndex = 1;
            // 
            // btResetle
            // 
            this.btResetle.Location = new System.Drawing.Point(553, 77);
            this.btResetle.Name = "btResetle";
            this.btResetle.Size = new System.Drawing.Size(129, 37);
            this.btResetle.TabIndex = 2;
            this.btResetle.Text = "Resetle";
            this.btResetle.UseVisualStyleBackColor = true;
            this.btResetle.Click += new System.EventHandler(this.btResetle_Click);
            // 
            // lbCift
            // 
            this.lbCift.FormattingEnabled = true;
            this.lbCift.ItemHeight = 16;
            this.lbCift.Location = new System.Drawing.Point(269, 151);
            this.lbCift.Name = "lbCift";
            this.lbCift.Size = new System.Drawing.Size(194, 388);
            this.lbCift.TabIndex = 3;
            // 
            // lbTek
            // 
            this.lbTek.FormattingEnabled = true;
            this.lbTek.ItemHeight = 16;
            this.lbTek.Location = new System.Drawing.Point(488, 151);
            this.lbTek.Name = "lbTek";
            this.lbTek.Size = new System.Drawing.Size(194, 388);
            this.lbTek.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Çiftler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tekler";
            // 
            // btDagit
            // 
            this.btDagit.Location = new System.Drawing.Point(269, 77);
            this.btDagit.Name = "btDagit";
            this.btDagit.Size = new System.Drawing.Size(129, 37);
            this.btDagit.TabIndex = 7;
            this.btDagit.Text = "Dağıt";
            this.btDagit.UseVisualStyleBackColor = true;
            this.btDagit.Click += new System.EventHandler(this.btDagit_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 730);
            this.Controls.Add(this.btDagit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTek);
            this.Controls.Add(this.lbCift);
            this.Controls.Add(this.btResetle);
            this.Controls.Add(this.lb20);
            this.Controls.Add(this.btEkle);
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.ListBox lb20;
        private System.Windows.Forms.Button btResetle;
        private System.Windows.Forms.ListBox lbCift;
        private System.Windows.Forms.ListBox lbTek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDagit;
    }
}
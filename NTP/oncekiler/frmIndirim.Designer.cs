namespace NTP
{
    partial class frmIndirim
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
            this.bt10 = new System.Windows.Forms.Button();
            this.bt75 = new System.Windows.Forms.Button();
            this.bt50 = new System.Windows.Forms.Button();
            this.bt25 = new System.Windows.Forms.Button();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIndirimliFiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt10
            // 
            this.bt10.Location = new System.Drawing.Point(32, 74);
            this.bt10.Name = "bt10";
            this.bt10.Size = new System.Drawing.Size(100, 100);
            this.bt10.TabIndex = 0;
            this.bt10.Text = "%10 indirim";
            this.bt10.UseVisualStyleBackColor = true;
            this.bt10.Click += new System.EventHandler(this.bt10_Click);
            // 
            // bt75
            // 
            this.bt75.Location = new System.Drawing.Point(350, 74);
            this.bt75.Name = "bt75";
            this.bt75.Size = new System.Drawing.Size(100, 100);
            this.bt75.TabIndex = 1;
            this.bt75.Text = "%75 indirim";
            this.bt75.UseVisualStyleBackColor = true;
            this.bt75.Click += new System.EventHandler(this.bt75_Click);
            // 
            // bt50
            // 
            this.bt50.Location = new System.Drawing.Point(244, 74);
            this.bt50.Name = "bt50";
            this.bt50.Size = new System.Drawing.Size(100, 100);
            this.bt50.TabIndex = 2;
            this.bt50.Text = "%50 indirim";
            this.bt50.UseVisualStyleBackColor = true;
            this.bt50.Click += new System.EventHandler(this.bt50_Click);
            // 
            // bt25
            // 
            this.bt25.Location = new System.Drawing.Point(138, 74);
            this.bt25.Name = "bt25";
            this.bt25.Size = new System.Drawing.Size(100, 100);
            this.bt25.TabIndex = 3;
            this.bt25.Text = "%25 indirim";
            this.bt25.UseVisualStyleBackColor = true;
            this.bt25.Click += new System.EventHandler(this.bt25_Click);
            // 
            // tbFiyat
            // 
            this.tbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFiyat.Location = new System.Drawing.Point(162, 30);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(121, 30);
            this.tbFiyat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Etiket fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "İndirimli fiyatı:";
            // 
            // lbIndirimliFiyat
            // 
            this.lbIndirimliFiyat.AutoSize = true;
            this.lbIndirimliFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIndirimliFiyat.ForeColor = System.Drawing.Color.Red;
            this.lbIndirimliFiyat.Location = new System.Drawing.Point(158, 191);
            this.lbIndirimliFiyat.Name = "lbIndirimliFiyat";
            this.lbIndirimliFiyat.Size = new System.Drawing.Size(0, 20);
            this.lbIndirimliFiyat.TabIndex = 7;
            // 
            // frmIndirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 283);
            this.Controls.Add(this.lbIndirimliFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.bt25);
            this.Controls.Add(this.bt50);
            this.Controls.Add(this.bt75);
            this.Controls.Add(this.bt10);
            this.Name = "frmIndirim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndirim hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt10;
        private System.Windows.Forms.Button bt75;
        private System.Windows.Forms.Button bt50;
        private System.Windows.Forms.Button bt25;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIndirimliFiyat;
    }
}
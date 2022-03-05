namespace NTP
{
    partial class frmRenkDegisimi
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
            this.rbSari = new System.Windows.Forms.RadioButton();
            this.rbKirmizi = new System.Windows.Forms.RadioButton();
            this.rbMavi = new System.Windows.Forms.RadioButton();
            this.btRenkDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSari
            // 
            this.rbSari.AutoSize = true;
            this.rbSari.Location = new System.Drawing.Point(50, 59);
            this.rbSari.Name = "rbSari";
            this.rbSari.Size = new System.Drawing.Size(54, 21);
            this.rbSari.TabIndex = 0;
            this.rbSari.TabStop = true;
            this.rbSari.Text = "Sarı";
            this.rbSari.UseVisualStyleBackColor = true;
            // 
            // rbKirmizi
            // 
            this.rbKirmizi.AutoSize = true;
            this.rbKirmizi.Location = new System.Drawing.Point(50, 86);
            this.rbKirmizi.Name = "rbKirmizi";
            this.rbKirmizi.Size = new System.Drawing.Size(70, 21);
            this.rbKirmizi.TabIndex = 1;
            this.rbKirmizi.TabStop = true;
            this.rbKirmizi.Text = "Kırmızı";
            this.rbKirmizi.UseVisualStyleBackColor = true;
            // 
            // rbMavi
            // 
            this.rbMavi.AutoSize = true;
            this.rbMavi.Location = new System.Drawing.Point(50, 113);
            this.rbMavi.Name = "rbMavi";
            this.rbMavi.Size = new System.Drawing.Size(58, 21);
            this.rbMavi.TabIndex = 2;
            this.rbMavi.TabStop = true;
            this.rbMavi.Text = "Mavi";
            this.rbMavi.UseVisualStyleBackColor = true;
            // 
            // btRenkDegistir
            // 
            this.btRenkDegistir.Location = new System.Drawing.Point(50, 140);
            this.btRenkDegistir.Name = "btRenkDegistir";
            this.btRenkDegistir.Size = new System.Drawing.Size(142, 36);
            this.btRenkDegistir.TabIndex = 3;
            this.btRenkDegistir.Text = "Renk Değiştir";
            this.btRenkDegistir.UseVisualStyleBackColor = true;
            this.btRenkDegistir.Click += new System.EventHandler(this.btRenkDegistir_Click);
            // 
            // frmRenkDegisimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 229);
            this.Controls.Add(this.btRenkDegistir);
            this.Controls.Add(this.rbMavi);
            this.Controls.Add(this.rbKirmizi);
            this.Controls.Add(this.rbSari);
            this.Name = "frmRenkDegisimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renk Değişimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSari;
        private System.Windows.Forms.RadioButton rbKirmizi;
        private System.Windows.Forms.RadioButton rbMavi;
        private System.Windows.Forms.Button btRenkDegistir;
    }
}
namespace NTP
{
    partial class form3
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
            this.btOgrenciSayisi = new System.Windows.Forms.Button();
            this.btTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOgrenciSayisi
            // 
            this.btOgrenciSayisi.Location = new System.Drawing.Point(43, 66);
            this.btOgrenciSayisi.Name = "btOgrenciSayisi";
            this.btOgrenciSayisi.Size = new System.Drawing.Size(160, 51);
            this.btOgrenciSayisi.TabIndex = 0;
            this.btOgrenciSayisi.Text = "Öğrenci sayısı";
            this.btOgrenciSayisi.UseVisualStyleBackColor = true;
            this.btOgrenciSayisi.Click += new System.EventHandler(this.btOgrenciSayisi_Click);
            // 
            // btTopla
            // 
            this.btTopla.Location = new System.Drawing.Point(240, 66);
            this.btTopla.Name = "btTopla";
            this.btTopla.Size = new System.Drawing.Size(107, 51);
            this.btTopla.TabIndex = 1;
            this.btTopla.Text = "İki sayısı topla";
            this.btTopla.UseVisualStyleBackColor = true;
            this.btTopla.Click += new System.EventHandler(this.btTopla_Click);
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 305);
            this.Controls.Add(this.btTopla);
            this.Controls.Add(this.btOgrenciSayisi);
            this.Name = "form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOgrenciSayisi;
        private System.Windows.Forms.Button btTopla;
    }
}
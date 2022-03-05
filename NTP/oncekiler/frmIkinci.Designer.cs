namespace NTP
{
    partial class frmIkinci
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
            this.btOzelikDegistir = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOzelikDegistir
            // 
            this.btOzelikDegistir.Location = new System.Drawing.Point(52, 46);
            this.btOzelikDegistir.Name = "btOzelikDegistir";
            this.btOzelikDegistir.Size = new System.Drawing.Size(162, 43);
            this.btOzelikDegistir.TabIndex = 0;
            this.btOzelikDegistir.Text = "Özelliğini Değiştir";
            this.btOzelikDegistir.UseVisualStyleBackColor = true;
            this.btOzelikDegistir.Click += new System.EventHandler(this.btOzelikDegistir_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(52, 104);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(162, 22);
            this.tb1.TabIndex = 1;
            // 
            // frmIkinci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 223);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btOzelikDegistir);
            this.Name = "frmIkinci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOzelikDegistir;
        private System.Windows.Forms.TextBox tb1;
    }
}
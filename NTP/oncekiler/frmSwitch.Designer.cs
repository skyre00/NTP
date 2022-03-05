namespace NTP
{
    partial class frmSwitch
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
            this.btKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDeger
            // 
            this.tbDeger.Location = new System.Drawing.Point(71, 55);
            this.tbDeger.Name = "tbDeger";
            this.tbDeger.Size = new System.Drawing.Size(100, 22);
            this.tbDeger.TabIndex = 0;
            // 
            // btKontrol
            // 
            this.btKontrol.Location = new System.Drawing.Point(193, 55);
            this.btKontrol.Name = "btKontrol";
            this.btKontrol.Size = new System.Drawing.Size(75, 23);
            this.btKontrol.TabIndex = 1;
            this.btKontrol.Text = "Kontrol Et";
            this.btKontrol.UseVisualStyleBackColor = true;
            this.btKontrol.Click += new System.EventHandler(this.btKontrol_Click);
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 127);
            this.Controls.Add(this.btKontrol);
            this.Controls.Add(this.tbDeger);
            this.Name = "frmSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSwitch";
            this.Load += new System.EventHandler(this.frmSwitch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDeger;
        private System.Windows.Forms.Button btKontrol;
    }
}
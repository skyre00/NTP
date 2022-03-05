namespace NTP
{
    partial class frmBreak
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
            this.tb100 = new System.Windows.Forms.TextBox();
            this.btBreak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb100
            // 
            this.tb100.Enabled = false;
            this.tb100.Location = new System.Drawing.Point(12, 74);
            this.tb100.Multiline = true;
            this.tb100.Name = "tb100";
            this.tb100.ReadOnly = true;
            this.tb100.Size = new System.Drawing.Size(256, 241);
            this.tb100.TabIndex = 14;
            // 
            // btBreak
            // 
            this.btBreak.Location = new System.Drawing.Point(12, 12);
            this.btBreak.Name = "btBreak";
            this.btBreak.Size = new System.Drawing.Size(256, 56);
            this.btBreak.TabIndex = 13;
            this.btBreak.Text = "(Break) 100\'e kadar 1\'er 1\'er arttır";
            this.btBreak.UseVisualStyleBackColor = true;
            this.btBreak.Click += new System.EventHandler(this.btBreak_Click);
            // 
            // frmBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 457);
            this.Controls.Add(this.tb100);
            this.Controls.Add(this.btBreak);
            this.Name = "frmBreak";
            this.Text = "frmBreak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb100;
        private System.Windows.Forms.Button btBreak;
    }
}
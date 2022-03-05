namespace NTP
{
    partial class frmDoWhile
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
            this.btSayDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb100
            // 
            this.tb100.Enabled = false;
            this.tb100.Location = new System.Drawing.Point(12, 86);
            this.tb100.Multiline = true;
            this.tb100.Name = "tb100";
            this.tb100.ReadOnly = true;
            this.tb100.Size = new System.Drawing.Size(256, 241);
            this.tb100.TabIndex = 12;
            // 
            // btSayDoWhile
            // 
            this.btSayDoWhile.Location = new System.Drawing.Point(12, 24);
            this.btSayDoWhile.Name = "btSayDoWhile";
            this.btSayDoWhile.Size = new System.Drawing.Size(256, 56);
            this.btSayDoWhile.TabIndex = 11;
            this.btSayDoWhile.Text = "(Do While) 100\'e kadar 1\'er 1\'er arttır";
            this.btSayDoWhile.UseVisualStyleBackColor = true;
            this.btSayDoWhile.Click += new System.EventHandler(this.btSayDoWhile_Click);
            // 
            // frmDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 534);
            this.Controls.Add(this.tb100);
            this.Controls.Add(this.btSayDoWhile);
            this.Name = "frmDoWhile";
            this.Text = "frmDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb100;
        private System.Windows.Forms.Button btSayDoWhile;
    }
}
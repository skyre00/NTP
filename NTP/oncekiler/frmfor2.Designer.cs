namespace NTP
{
    partial class frmfor2
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
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.bt17 = new System.Windows.Forms.Button();
            this.bt10ar10ar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSonuc
            // 
            this.tbSonuc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSonuc.Location = new System.Drawing.Point(12, 145);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSonuc.Size = new System.Drawing.Size(663, 322);
            this.tbSonuc.TabIndex = 4;
            // 
            // bt17
            // 
            this.bt17.Location = new System.Drawing.Point(12, 24);
            this.bt17.Name = "bt17";
            this.bt17.Size = new System.Drawing.Size(157, 98);
            this.bt17.TabIndex = 3;
            this.bt17.Text = "100 den 1 kadar eksil";
            this.bt17.UseVisualStyleBackColor = true;
            this.bt17.Click += new System.EventHandler(this.bt17_Click);
            // 
            // bt10ar10ar
            // 
            this.bt10ar10ar.Location = new System.Drawing.Point(212, 24);
            this.bt10ar10ar.Name = "bt10ar10ar";
            this.bt10ar10ar.Size = new System.Drawing.Size(313, 98);
            this.bt10ar10ar.TabIndex = 5;
            this.bt10ar10ar.Text = "100 den 1 kadar 10 ar 10ar  eksil";
            this.bt10ar10ar.UseVisualStyleBackColor = true;
            this.bt10ar10ar.Click += new System.EventHandler(this.bt10ar10ar_Click);
            // 
            // frmfor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 769);
            this.Controls.Add(this.bt10ar10ar);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.bt17);
            this.Name = "frmfor2";
            this.Text = "frmfor2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.Button bt17;
        private System.Windows.Forms.Button bt10ar10ar;
    }
}
namespace NTP
{
    partial class frmwhile
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
            this.btSayFor = new System.Windows.Forms.Button();
            this.tb100 = new System.Windows.Forms.TextBox();
            this.tbWhileSay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSayFor
            // 
            this.btSayFor.Location = new System.Drawing.Point(23, 12);
            this.btSayFor.Name = "btSayFor";
            this.btSayFor.Size = new System.Drawing.Size(221, 56);
            this.btSayFor.TabIndex = 3;
            this.btSayFor.Text = "(for) 100\'e kadar 1\'er 1\'er arttır";
            this.btSayFor.UseVisualStyleBackColor = true;
            this.btSayFor.Click += new System.EventHandler(this.btSayFor_Click);
            // 
            // tb100
            // 
            this.tb100.Enabled = false;
            this.tb100.Location = new System.Drawing.Point(23, 74);
            this.tb100.Multiline = true;
            this.tb100.Name = "tb100";
            this.tb100.ReadOnly = true;
            this.tb100.Size = new System.Drawing.Size(221, 241);
            this.tb100.TabIndex = 10;
            // 
            // tbWhileSay
            // 
            this.tbWhileSay.Location = new System.Drawing.Point(278, 12);
            this.tbWhileSay.Name = "tbWhileSay";
            this.tbWhileSay.Size = new System.Drawing.Size(221, 56);
            this.tbWhileSay.TabIndex = 11;
            this.tbWhileSay.Text = "(while) 100\'e kadar 1\'er 1\'er arttır";
            this.tbWhileSay.UseVisualStyleBackColor = true;
            this.tbWhileSay.Click += new System.EventHandler(this.tbWhileSay_Click);
            // 
            // frmwhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 380);
            this.Controls.Add(this.tbWhileSay);
            this.Controls.Add(this.tb100);
            this.Controls.Add(this.btSayFor);
            this.Name = "frmwhile";
            this.Text = "frmwhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSayFor;
        private System.Windows.Forms.TextBox tb100;
        private System.Windows.Forms.Button tbWhileSay;
    }
}
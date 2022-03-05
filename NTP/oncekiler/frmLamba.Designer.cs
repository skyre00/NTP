namespace NTP
{
    partial class frmLamba
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
            this.cbAcKapa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAcKapa
            // 
            this.cbAcKapa.AutoSize = true;
            this.cbAcKapa.Location = new System.Drawing.Point(47, 51);
            this.cbAcKapa.Name = "cbAcKapa";
            this.cbAcKapa.Size = new System.Drawing.Size(83, 21);
            this.cbAcKapa.TabIndex = 0;
            this.cbAcKapa.Text = "Aç/Kapa";
            this.cbAcKapa.UseVisualStyleBackColor = true;
            this.cbAcKapa.CheckedChanged += new System.EventHandler(this.cbAcKapa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lambanın Durumu";
            // 
            // lbDurum
            // 
            this.lbDurum.AutoSize = true;
            this.lbDurum.Location = new System.Drawing.Point(190, 75);
            this.lbDurum.Name = "lbDurum";
            this.lbDurum.Size = new System.Drawing.Size(0, 17);
            this.lbDurum.TabIndex = 2;
            // 
            // frmLamba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(260, 137);
            this.Controls.Add(this.lbDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAcKapa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmLamba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLamba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAcKapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDurum;
    }
}
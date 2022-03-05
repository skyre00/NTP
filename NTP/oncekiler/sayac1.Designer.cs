namespace NTP
{
    partial class frmSayac
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
            this.btSay = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.btArttir3 = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.tbArttir = new System.Windows.Forms.TextBox();
            this.btArttirAbi = new System.Windows.Forms.Button();
            this.lbKacarKacar = new System.Windows.Forms.Label();
            this.btSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSay
            // 
            this.btSay.Location = new System.Drawing.Point(71, 56);
            this.btSay.Name = "btSay";
            this.btSay.Size = new System.Drawing.Size(99, 59);
            this.btSay.TabIndex = 0;
            this.btSay.Text = "Arttır +1";
            this.btSay.UseVisualStyleBackColor = true;
            this.btSay.Click += new System.EventHandler(this.btSay_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(96, 129);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 17);
            this.lb1.TabIndex = 1;
            // 
            // btArttir3
            // 
            this.btArttir3.Location = new System.Drawing.Point(206, 56);
            this.btArttir3.Name = "btArttir3";
            this.btArttir3.Size = new System.Drawing.Size(99, 59);
            this.btArttir3.TabIndex = 2;
            this.btArttir3.Text = "Arttır +3";
            this.btArttir3.UseVisualStyleBackColor = true;
            this.btArttir3.Click += new System.EventHandler(this.btArttir3_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(228, 129);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(0, 17);
            this.lb3.TabIndex = 3;
            // 
            // tbArttir
            // 
            this.tbArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbArttir.Location = new System.Drawing.Point(440, 21);
            this.tbArttir.Name = "tbArttir";
            this.tbArttir.Size = new System.Drawing.Size(195, 26);
            this.tbArttir.TabIndex = 4;
            // 
            // btArttirAbi
            // 
            this.btArttirAbi.Location = new System.Drawing.Point(440, 56);
            this.btArttirAbi.Name = "btArttirAbi";
            this.btArttirAbi.Size = new System.Drawing.Size(195, 59);
            this.btArttirAbi.TabIndex = 5;
            this.btArttirAbi.Text = "Abi kaçar kaçar?? asdf +/*-";
            this.btArttirAbi.UseVisualStyleBackColor = true;
            this.btArttirAbi.Click += new System.EventHandler(this.btArttirAbi_Click);
            // 
            // lbKacarKacar
            // 
            this.lbKacarKacar.AutoSize = true;
            this.lbKacarKacar.Location = new System.Drawing.Point(497, 129);
            this.lbKacarKacar.Name = "lbKacarKacar";
            this.lbKacarKacar.Size = new System.Drawing.Size(0, 17);
            this.lbKacarKacar.TabIndex = 6;
            // 
            // btSifirla
            // 
            this.btSifirla.Location = new System.Drawing.Point(651, 56);
            this.btSifirla.Name = "btSifirla";
            this.btSifirla.Size = new System.Drawing.Size(99, 59);
            this.btSifirla.TabIndex = 7;
            this.btSifirla.Text = "Sıfırla";
            this.btSifirla.UseVisualStyleBackColor = true;
            this.btSifirla.Click += new System.EventHandler(this.btSifirla_Click);
            // 
            // frmSayac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 173);
            this.Controls.Add(this.btSifirla);
            this.Controls.Add(this.lbKacarKacar);
            this.Controls.Add(this.btArttirAbi);
            this.Controls.Add(this.tbArttir);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btArttir3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btSay);
            this.Name = "frmSayac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayaç 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSay;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btArttir3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox tbArttir;
        private System.Windows.Forms.Button btArttirAbi;
        private System.Windows.Forms.Label lbKacarKacar;
        private System.Windows.Forms.Button btSifirla;
    }
}
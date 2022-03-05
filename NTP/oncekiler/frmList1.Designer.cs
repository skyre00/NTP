namespace NTP
{
    partial class frmList1
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
            this.lbEklenenler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIsim = new System.Windows.Forms.TextBox();
            this.tbSoyisim = new System.Windows.Forms.TextBox();
            this.btEkle = new System.Windows.Forms.Button();
            this.btAsagiEkle = new System.Windows.Forms.Button();
            this.btKacElemanVar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumara = new System.Windows.Forms.TextBox();
            this.btNumarayaGoreSiralaClassiz = new System.Windows.Forms.Button();
            this.btIsmeGoreSiralaClassli = new System.Windows.Forms.Button();
            this.btNumarayaGoreSiralaClassli = new System.Windows.Forms.Button();
            this.btSoyismeGoreSiralaClassli = new System.Windows.Forms.Button();
            this.btBilgileriOtomatikEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEklenenler
            // 
            this.lbEklenenler.FormattingEnabled = true;
            this.lbEklenenler.ItemHeight = 16;
            this.lbEklenenler.Location = new System.Drawing.Point(119, 276);
            this.lbEklenenler.Name = "lbEklenenler";
            this.lbEklenenler.Size = new System.Drawing.Size(435, 244);
            this.lbEklenenler.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "İsim";
            // 
            // tbIsim
            // 
            this.tbIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbIsim.Location = new System.Drawing.Point(106, 53);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(100, 30);
            this.tbIsim.TabIndex = 1;
            // 
            // tbSoyisim
            // 
            this.tbSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyisim.Location = new System.Drawing.Point(106, 89);
            this.tbSoyisim.Name = "tbSoyisim";
            this.tbSoyisim.Size = new System.Drawing.Size(100, 30);
            this.tbSoyisim.TabIndex = 2;
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(212, 12);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(113, 51);
            this.btEkle.TabIndex = 19;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // btAsagiEkle
            // 
            this.btAsagiEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAsagiEkle.Location = new System.Drawing.Point(131, 219);
            this.btAsagiEkle.Name = "btAsagiEkle";
            this.btAsagiEkle.Size = new System.Drawing.Size(194, 51);
            this.btAsagiEkle.TabIndex = 25;
            this.btAsagiEkle.Text = "Aşağı ekle";
            this.btAsagiEkle.UseVisualStyleBackColor = true;
            this.btAsagiEkle.Click += new System.EventHandler(this.btAsagiEkle_Click);
            // 
            // btKacElemanVar
            // 
            this.btKacElemanVar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKacElemanVar.Location = new System.Drawing.Point(344, 42);
            this.btKacElemanVar.Name = "btKacElemanVar";
            this.btKacElemanVar.Size = new System.Drawing.Size(332, 51);
            this.btKacElemanVar.TabIndex = 26;
            this.btKacElemanVar.Text = "Koleksiyonun kaç elemanı var";
            this.btKacElemanVar.UseVisualStyleBackColor = true;
            this.btKacElemanVar.Click += new System.EventHandler(this.btKacElemanVar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Numara";
            // 
            // tbNumara
            // 
            this.tbNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNumara.Location = new System.Drawing.Point(106, 12);
            this.tbNumara.Name = "tbNumara";
            this.tbNumara.Size = new System.Drawing.Size(100, 30);
            this.tbNumara.TabIndex = 0;
            // 
            // btNumarayaGoreSiralaClassiz
            // 
            this.btNumarayaGoreSiralaClassiz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btNumarayaGoreSiralaClassiz.Location = new System.Drawing.Point(569, 276);
            this.btNumarayaGoreSiralaClassiz.Name = "btNumarayaGoreSiralaClassiz";
            this.btNumarayaGoreSiralaClassiz.Size = new System.Drawing.Size(351, 50);
            this.btNumarayaGoreSiralaClassiz.TabIndex = 30;
            this.btNumarayaGoreSiralaClassiz.Text = "İsme göre sırala (ClassSIZ)";
            this.btNumarayaGoreSiralaClassiz.UseVisualStyleBackColor = true;
            this.btNumarayaGoreSiralaClassiz.Click += new System.EventHandler(this.btNumarayaGoreSirala_Click);
            // 
            // btIsmeGoreSiralaClassli
            // 
            this.btIsmeGoreSiralaClassli.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIsmeGoreSiralaClassli.Location = new System.Drawing.Point(940, 276);
            this.btIsmeGoreSiralaClassli.Name = "btIsmeGoreSiralaClassli";
            this.btIsmeGoreSiralaClassli.Size = new System.Drawing.Size(351, 50);
            this.btIsmeGoreSiralaClassli.TabIndex = 31;
            this.btIsmeGoreSiralaClassli.Text = "İsme göre sırala (ClassLI)";
            this.btIsmeGoreSiralaClassli.UseVisualStyleBackColor = true;
            this.btIsmeGoreSiralaClassli.Click += new System.EventHandler(this.btIsmeGoreSiralaClassli_Click);
            // 
            // btNumarayaGoreSiralaClassli
            // 
            this.btNumarayaGoreSiralaClassli.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btNumarayaGoreSiralaClassli.Location = new System.Drawing.Point(940, 332);
            this.btNumarayaGoreSiralaClassli.Name = "btNumarayaGoreSiralaClassli";
            this.btNumarayaGoreSiralaClassli.Size = new System.Drawing.Size(351, 50);
            this.btNumarayaGoreSiralaClassli.TabIndex = 32;
            this.btNumarayaGoreSiralaClassli.Text = "Numaraya göre sırala (ClassLI)";
            this.btNumarayaGoreSiralaClassli.UseVisualStyleBackColor = true;
            this.btNumarayaGoreSiralaClassli.Click += new System.EventHandler(this.btNumarayaGoreSiralaClassli_Click);
            // 
            // btSoyismeGoreSiralaClassli
            // 
            this.btSoyismeGoreSiralaClassli.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSoyismeGoreSiralaClassli.Location = new System.Drawing.Point(940, 388);
            this.btSoyismeGoreSiralaClassli.Name = "btSoyismeGoreSiralaClassli";
            this.btSoyismeGoreSiralaClassli.Size = new System.Drawing.Size(351, 50);
            this.btSoyismeGoreSiralaClassli.TabIndex = 33;
            this.btSoyismeGoreSiralaClassli.Text = "Soyisme göre sırala (ClassLI)";
            this.btSoyismeGoreSiralaClassli.UseVisualStyleBackColor = true;
            this.btSoyismeGoreSiralaClassli.Click += new System.EventHandler(this.btSoyismeGoreSiralaClassli_Click);
            // 
            // btBilgileriOtomatikEkle
            // 
            this.btBilgileriOtomatikEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBilgileriOtomatikEkle.Location = new System.Drawing.Point(716, 12);
            this.btBilgileriOtomatikEkle.Name = "btBilgileriOtomatikEkle";
            this.btBilgileriOtomatikEkle.Size = new System.Drawing.Size(310, 81);
            this.btBilgileriOtomatikEkle.TabIndex = 34;
            this.btBilgileriOtomatikEkle.Text = "Bilgileri Otomatik Ekle";
            this.btBilgileriOtomatikEkle.UseVisualStyleBackColor = true;
            this.btBilgileriOtomatikEkle.Click += new System.EventHandler(this.btBilgileriOtomatikEkle_Click);
            // 
            // frmList1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 716);
            this.Controls.Add(this.btBilgileriOtomatikEkle);
            this.Controls.Add(this.btSoyismeGoreSiralaClassli);
            this.Controls.Add(this.btNumarayaGoreSiralaClassli);
            this.Controls.Add(this.btIsmeGoreSiralaClassli);
            this.Controls.Add(this.btNumarayaGoreSiralaClassiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumara);
            this.Controls.Add(this.btKacElemanVar);
            this.Controls.Add(this.btAsagiEkle);
            this.Controls.Add(this.lbEklenenler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIsim);
            this.Controls.Add(this.tbSoyisim);
            this.Controls.Add(this.btEkle);
            this.Name = "frmList1";
            this.Text = "frmList1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEklenenler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIsim;
        private System.Windows.Forms.TextBox tbSoyisim;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Button btAsagiEkle;
        private System.Windows.Forms.Button btKacElemanVar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumara;
        private System.Windows.Forms.Button btNumarayaGoreSiralaClassiz;
        private System.Windows.Forms.Button btIsmeGoreSiralaClassli;
        private System.Windows.Forms.Button btNumarayaGoreSiralaClassli;
        private System.Windows.Forms.Button btSoyismeGoreSiralaClassli;
        private System.Windows.Forms.Button btBilgileriOtomatikEkle;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTP
{
    public partial class frmDizi3 : Form
    {
        public frmDizi3()
        {
            InitializeComponent();
        }


        private void btEkle_Click(object sender, EventArgs e)
        {
            if (sayac < kacElemanli)
            {
                isim[sayac] = tbIsimSoyisim.Text;
                not[sayac] = Convert.ToInt32(tbNotBilgisi.Text);
                sayac++;
                tbIsimSoyisim.Text = tbNotBilgisi.Text = null;
                tbIsimSoyisim.Focus();
            }
            else
            {
                MessageBox.Show("Yeteri kadar veri girişi yapılmıştır");
                tbIsimSoyisim.Text = tbNotBilgisi.Text = null;
                deAktiflestir();
                btHesapla.Enabled = true;

            }



        }

        private void btTanimla_Click(object sender, EventArgs e)
        {
            kacElemanli = Convert.ToInt32(tbKacSayi.Text);
            sayac = 0;
            isim = new string[kacElemanli];
            not = new int[kacElemanli];

            aktiflestir();


        }

        private void aktiflestir()
        {
            btEkle.Enabled = true;
            btHesapla.Enabled = true;
            tbIsimSoyisim.Enabled = true;
            tbNotBilgisi.Enabled = true;
        }
        private void deAktiflestir()
        {
            btEkle.Enabled = false;
            btHesapla.Enabled = false;
            tbIsimSoyisim.Enabled = false;
            tbNotBilgisi.Enabled = false;

        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            double ortalama = 0;
            for (int i = 0; i < kacElemanli; i++)
            {
                lbIsimSoyisim.Text += isim[i] + "-";
                lbNotBilgisi.Text += not[i].ToString() + "-";
                ortalama += not[i];
            }
            lbNotBilgisi.Text += " Ortalama=" + Convert.ToString(ortalama / kacElemanli);
        }


        // string[] isim  = new string();

        string[] isim;// = new string();
        int[] not;// = new int[];
        int sayac = 0; int kacElemanli = 0;

        private void frmDizi3_Load(object sender, EventArgs e)
        {
            deAktiflestir();
        }
    }
}

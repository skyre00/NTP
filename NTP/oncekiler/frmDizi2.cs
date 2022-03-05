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
    public partial class frmDizi2 : Form
    {
        public frmDizi2()
        {
            InitializeComponent();
        }


        string[] isim = new string[3];
        int[] not = new int[3];
        int sayac = 0;
        private void btEkle_Click(object sender, EventArgs e)
        {
            isim[sayac] = tbIsimSoyisim.Text;
            not[sayac] = Convert.ToInt32(tbNotBilgisi.Text);
            sayac++;
            tbIsimSoyisim.Text = tbNotBilgisi.Text = null;
            tbIsimSoyisim.Focus();
        }

        private void btTanimla_Click(object sender, EventArgs e)
        {

        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            double ortalama = 0;
            for (int i = 0; i < 3; i++)
            {
                lbIsimSoyisim.Text += isim[i] + "-";
                lbNotBilgisi.Text += not[i].ToString() + "-";
                ortalama += not[i];
            }
            lbNotBilgisi.Text += " Ortalama=" + Convert.ToString(ortalama / 3);
        }
    }
}

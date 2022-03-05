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
    public partial class frmTahmin : Form
    {
       public frmTahmin()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int rastgeleUretilen; int okunan;
        private void btTahminEt_Click(object sender, EventArgs e)
        {   okunan = Convert.ToInt32(tbTahmin.Text);
                if (okunan==rastgeleUretilen)
                {
                    lbSonuc.Text = "Bildiniz";
                }
                else
                {
                    lbSonuc.Text = "Yanlış cevap";
                }
            sayac++;
            if (sayac==3)
            {
                btTahminEt.Enabled = false;
            }
        }
         
        private void btSayiUret_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            rastgeleUretilen = r.Next(Convert.ToInt32(TBKacaKadar.Text));

            // rastgeleUretilen = r.Next(100); 0-100 arası rastgele değer üretir.
          //  this.Text = rastgeleUretilen.ToString();
        }
    }
}

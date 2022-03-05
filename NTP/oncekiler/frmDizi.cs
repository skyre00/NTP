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
    public partial class frmDizi : Form
    {
        public frmDizi()
        {
            InitializeComponent();
        }
        int carpim = 1, toplam = 0, kacAdet = 0,sayac=0;

        private void frmDizi_Load(object sender, EventArgs e)
        {
            lbGirilenDeger.Text = null;
        }

     //   public static int aliEfe = 1;
        private void btHesapla_Click(object sender, EventArgs e)
        {
            if (tbKacSayi.Text!=null)
            {
                kacAdet = Convert.ToInt16(tbKacSayi.Text);

            }

            carpim = carpim * Convert.ToInt16(tb1.Text);
            toplam = toplam + Convert.ToInt16(tb1.Text);

            lb1.Text = "Toplam=" + toplam.ToString() + " Çarpım=" + carpim.ToString();
            lbGirilenDeger.Text = lbGirilenDeger.Text + tb1.Text + " ";

            sayac++;
            if (sayac==kacAdet)
            {
                tb1.Enabled = false;
            }
        }
    }
}

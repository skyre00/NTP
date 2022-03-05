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
    public partial class frmDongu1 : Form
    {
        public frmDongu1()
        {
            InitializeComponent();
        }

        private void btSay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i=i+1)
            {
                lb1.Text = lb1.Text + " " + i;
                tb100.Text = lb1.Text;
            }
        }

        private void btSifirla_Click(object sender, EventArgs e)
        {
            lb1.Text = "";
            tb100.Text = "";
            tbSonuc.Text = "";
        }

        private void btAtesle_Click(object sender, EventArgs e)
        {
            int baslangis = Convert.ToInt32(tbBaslangic.Text);
            int adimSayisi = Convert.ToInt32(tbAdimSayisi.Text);
            int bitis = Convert.ToInt32(tbBitis.Text);

            for (int i = baslangis; i <= bitis; i=i+ adimSayisi)
            {
                tbSonuc.Text = tbSonuc.Text + " " + i.ToString();
            }

        }
    }
}

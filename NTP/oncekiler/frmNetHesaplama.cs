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
    public partial class frmNetHesaplama : Form
    {
        public frmNetHesaplama()
        {
            InitializeComponent();
        }

     

        private void btHesapla_Click(object sender, EventArgs e)
        {
            int turkceD = Convert.ToInt32(tbTurkceD.Text); // türkçe doğru sayısı
            int matD = Convert.ToInt32(tbMatD.Text); // matematik doğru sayısı

            int turkceY = Convert.ToInt32(tbTurkceY.Text);
            int matY = Convert.ToInt32(tbMatY.Text);

            double turkceN=turkceD-turkceY*0.25;
            double matN = matD - matY * 0.25;

            tbTurkceN.Text = turkceN.ToString();
            tbMatN.Text = matN.ToString();

        }
    }
}

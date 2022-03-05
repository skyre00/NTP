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
    public partial class frmTekMiCiftMi : Form
    {
        public frmTekMiCiftMi()
        {
            InitializeComponent();
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(tbSayi.Text);

            if (sayi%2==0)
            {
                MessageBox.Show("Sayınız çift", "Bilginize...", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Sayınız tek", "Bilginize...", MessageBoxButtons.OK);


            }
        }
    }
}

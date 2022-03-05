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
    public partial class frmHesaplama : Form
    {
        public frmHesaplama()
        {
            InitializeComponent();
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            if (rdTopla.Checked)
            {
                lbSonuc.Text = (Convert.ToInt32(tb1.Text) + Convert.ToInt32(tb2.Text)).ToString();
            }

            if (rdCarp.Checked)
            {
                lbSonuc.Text = (Convert.ToInt32(tb1.Text) * Convert.ToInt32(tb2.Text)).ToString();
            }
        }
    }
}

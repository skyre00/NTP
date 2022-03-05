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
    public partial class frmIndirim : Form
    {
        public frmIndirim()
        {
            InitializeComponent();
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(tbFiyat.Text);
            lbIndirimliFiyat.Text = Convert.ToString(fiyat * 0.9);
        }

        private void bt25_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(tbFiyat.Text);
            lbIndirimliFiyat.Text = (fiyat * 0.75).ToString();
        }

        private void bt50_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(tbFiyat.Text);
            lbIndirimliFiyat.Text = (fiyat * 0.50).ToString();
        }

        private void bt75_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(tbFiyat.Text);
            lbIndirimliFiyat.Text = (fiyat * 0.25).ToString();

        }
    }
}

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
    public partial class frmSayac : Form
    {
        public frmSayac()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void btSay_Click(object sender, EventArgs e)
        {
         
            sayac = sayac + 1; //    sayac++; i=i+1;
            lb1.Text = sayac.ToString();
        }

        int sayac3 = 0;
        private void btArttir3_Click(object sender, EventArgs e)
        {
            sayac3 = sayac3 + 3;
            lb3.Text = sayac3.ToString();

        }
        int sayParametrik = 0;
        private void btArttirAbi_Click(object sender, EventArgs e)
        {
            sayParametrik = sayParametrik + Convert.ToInt32(tbArttir.Text);
            lbKacarKacar.Text= sayParametrik.ToString();

        }

        private void btSifirla_Click(object sender, EventArgs e)
        {
            sayParametrik = 0;sayac = 0;sayac3 = 0;
            lb1.Text = 0.ToString();
            lb3.Text = 0.ToString();
            lbKacarKacar.Text = 0.ToString();
        }
    }
}

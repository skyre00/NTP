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
    public partial class frm1Bolumebilme : Form
    {
        public frm1Bolumebilme()
        {
            InitializeComponent();
        }

        private void bt17_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 17 == 0)
                {
                    tb17.Text += i.ToString() + " ";
                }
            }
        }

        private void frm1Bolumebilme_Load(object sender, EventArgs e)
        {  
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            int bolen = Convert.ToInt32(tbBolen.Text);
            int kacaKAdar = Convert.ToInt32(tbKacaKadar.Text);


            for (int i = 1; i <= kacaKAdar; i++)
            {
                if (i % bolen ==0)
                {
                    tb17.Text += i + " ";
                }
            }
        }
    }
}

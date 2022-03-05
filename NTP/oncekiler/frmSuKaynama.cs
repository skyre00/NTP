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
    public partial class frmSuKaynama : Form
    {
        public frmSuKaynama()
        {
            InitializeComponent();
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt16(tb1.Text);

            if (deger < 0)
            {
                MessageBox.Show("Katı halde", "Son durum", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (deger > 100)
                {
                    MessageBox.Show("Gaz halinde", "Son durum", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                else
                {
                    MessageBox.Show("Sıvı halde", "Son durum", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
            }
        }
    }
}

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
    public partial class frmKontrol : Form
    {
        public frmKontrol()
        {
            InitializeComponent();
        }

        private void btKarsilastir_Click(object sender, EventArgs e)
        {
            int bir = Convert.ToInt32(tb1.Text);
            int iki = Convert.ToInt32(tb2.Text);

            if (bir>iki)
            {
                MessageBox.Show(bir.ToString() + " sayısı (birinci sayı); " + iki.ToString() + " sayısından (ikinci sayı) büyük");
            }
            else
            {
                if (iki>bir)
                {
                    MessageBox.Show(iki.ToString() + " sayısı (ikinci sayı); " + bir.ToString() + " sayısından (birinci sayı) büyük");

                }
                else
                {
                    MessageBox.Show("Abi bu sayılar var ya, bu sayılar birbirine EŞİT!...");

                }
            }
        }
    }
}

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
    public partial class aritmetik : Form
    {
        public aritmetik()
        {
            InitializeComponent();
        }

        private void btModAl_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tbDeger.Text);
            lbSonuc.Text = (a % 2).ToString();
        }

        private void btCevir_Click(object sender, EventArgs e)
        {
            //  lbSonuc.Text = tbKontrol.Text;
            /*     test
                    test burada açıklama satırı var
      */
            int a =Convert.ToInt32( tbKontrol.Text);
      
            a = a * a;
            // lbSonuc.Text = Convert.ToString(a);
            lbSonuc.Text = a.ToString(); // üstteki satırla bu satır aynı işi yapıyor 06/10/2021

            
        }

        private void btIslemOnceligi_Click(object sender, EventArgs e)
        {
            int a;
            // int a = 4 + 3 + 6;// 13


            // int a = 4/2*5;// 10
            //  double a = 4 / (2 * 5);// 0,4
            //    int a = (4 / 2 * 3) + (9 / 3);// 9

            //   int a = 4 / 2 * 3 + 9 / 3; //

            a = 9 / 3 + 2 * 2 - 4 + 1; //8 6 9 7 




            lbSonuc.Text = a.ToString();
        }
    }
}

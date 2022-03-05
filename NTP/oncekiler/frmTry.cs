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
    public partial class frmTry : Form
    {
        public frmTry()
        {
            InitializeComponent();
        }

        private void btTopla_Click(object sender, EventArgs e)
        {
            f(Convert.ToInt16(tb1.Text), Convert.ToInt16(tb2.Text));
/*
            try
            {

                int s1 = Convert.ToInt16(tb1.Text), s2 = Convert.ToInt16(tb2.Text);
                MessageBox.Show((s1 + s2).ToString(), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception w)
            {


                string durum = " Kutu1=" + tb1.Text + "--- Kutu2=" + tb2.Text + "--- Hata mesajı=" + w.Message.ToString();
                MessageBox.Show(durum, "Hata var", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            */
        }

        private void f(int x, int y)
        {
            int sonuc = x + y;

            MessageBox.Show(sonuc.ToString());

            
            int i = 0,ii = 0;


            int xx = 0;
            int yy = 0;
        }

    }
}

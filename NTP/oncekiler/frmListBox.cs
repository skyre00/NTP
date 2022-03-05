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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btEkle_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                lb20.Items.Add(r.Next(100));
            }
        }

        private void btResetle_Click(object sender, EventArgs e)
        {
            lb20.Items.Clear();
            lbCift.Items.Clear();
            lbTek.Items.Clear();
        }

        private void btDagit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                if (Convert.ToInt32(lb20.Items[i])%2==0)
                {
                    lbCift.Items.Add(lb20.Items[i]);
                }
                else
                {
                    lbTek.Items.Add(lb20.Items[i]);
                }
            }
        }
    }
}

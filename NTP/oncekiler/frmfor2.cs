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
    public partial class frmfor2 : Form
    {
        public frmfor2()
        {
            InitializeComponent();
        }

        private void bt17_Click(object sender, EventArgs e)
        {
            for (int i = 100; i > 0; i=i-1)
            {
                tbSonuc.Text += i + " ";
            }
        }

        private void bt10ar10ar_Click(object sender, EventArgs e)
        {
            for (int i = 100; i > 0; i = i - 10)
            {
                tbSonuc.Text += i + " ";
            }
        }
    }
}

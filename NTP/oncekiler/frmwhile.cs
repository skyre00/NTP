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
    public partial class frmwhile : Form
    {
        public frmwhile()
        {
            InitializeComponent();
        }

        private void btSay_Click(object sender, EventArgs e)
        {

        }

        private void btSayFor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i = i + 3)
            {
                tb100.Text = tb100.Text + " " + i;
            }
        }

        private void tbWhileSay_Click(object sender, EventArgs e)
        { int i =-100;
            while (i<10)
            {
                tb100.Text = tb100.Text + " " + i;
                i = i + 3;
            }
        }
    }
}

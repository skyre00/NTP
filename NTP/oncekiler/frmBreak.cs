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
    public partial class frmBreak : Form
    {
        public frmBreak()
        {
            InitializeComponent();
        }

        private void btBreak_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 800; i++)
            {
                tb100.Text = tb100.Text + " " + i;

                if (i == 150)
                {
                    break;
                }
            }
        }
    }
}

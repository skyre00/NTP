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
    public partial class frmContinue : Form
    {
        public frmContinue()
        {
            InitializeComponent();
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                tb100.Text = tb100.Text + " " + i;
            }
        }
    }
}

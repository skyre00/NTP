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
    public partial class frmDoWhile : Form
    {
        public frmDoWhile()
        {
            InitializeComponent();
        }

        private void btSayDoWhile_Click(object sender, EventArgs e)
        {
            int say = 0;
            do
            {
                tb100.Text = tb100.Text + " " + say;
                say++;
            } while (say<10);
        }
    }
}

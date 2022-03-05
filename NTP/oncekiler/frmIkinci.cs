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
    public partial class frmIkinci : Form
    {
        public frmIkinci()
        {
            InitializeComponent();
        }

        private void btOzelikDegistir_Click(object sender, EventArgs e)
        {
            tb1.ForeColor = Color.Red;
            //  tb1.Enabled = false;
            //  tb1.Visible = false;

            tb1.Font = new Font("Verdana", 25);
        }
    }
}

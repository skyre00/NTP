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
    public partial class frmLamba : Form
    {
        public frmLamba()
        {
            InitializeComponent();
        }

        private void cbAcKapa_CheckedChanged(object sender, EventArgs e)
        {
            bool durum;
            durum = cbAcKapa.Checked;
            lbDurum.Text = durum.ToString();
        }
    }
}

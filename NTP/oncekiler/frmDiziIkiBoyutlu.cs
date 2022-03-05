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
    public partial class frmDiziIkiBoyutlu : Form
    {
        public frmDiziIkiBoyutlu()
        {
            InitializeComponent();
        }


        int i = 0;
        string[,] bilgi = new string[5,2];
        private void btEkle_Click(object sender, EventArgs e)
        {
            if (i<26)
            {
                bilgi[i, 0] = tbIsim.Text;
                bilgi[i, 1] = tbSoyisim.Text;
            }
            i++;

          
        }
    }
}

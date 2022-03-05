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
    public partial class frmRenkDegisimi : Form
    {
        public frmRenkDegisimi()
        {
            InitializeComponent();
        }

        private void btRenkDegistir_Click(object sender, EventArgs e)
        {
            if (rbSari.Checked==true) // ==true yazmayabilirim de, bilginiz olsun
            {
                this.BackColor = Color.Yellow;
            }


            if (rbMavi.Checked) // ==true yazabilirim de, bilginiz olsun
            {
                this.BackColor = Color.Blue;
            }


            if (rbKirmizi.Checked==true)
            {
                this.BackColor = Color.Red;
            }
        }
    }
}

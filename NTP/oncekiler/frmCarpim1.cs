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
    public partial class frmCarpim1 : Form
    {
        public frmCarpim1()
        {
            InitializeComponent();
        }

        private void btCarpim_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                tbTablo.Text = tbTablo.Text+ 1+
                    "x"+i.ToString()+"="+1*i  + Environment.NewLine ;
            }
        }

        private void frmCarpim1_Load(object sender, EventArgs e)
        {
            //  tbCarpimTablosu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            // tbCarpimTablosu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbCarpimTablosu.WordWrap = false;

    /*        VScrollBar vScroller = new VScrollBar();
            vScroller.Dock = DockStyle.Right;
           
            vScroller.Name = "VScrollBar1";
            tbCarpimTablosu.Controls.Add(vScroller);
*/

        }

       
        private void btIcIce_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    tbCarpimTablosu.Text = tbCarpimTablosu.Text + j + " ";
                }

                tbCarpimTablosu.Text += Environment.NewLine;   //  tbCarpimTablosu.Text = tbCarpimTablosu.Text + Environment.NewLine;  


            }
        }

        private void btCarpimTablosu_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    tbCarpimTablosu.Text = tbCarpimTablosu.Text + j.ToString() +
                   "x" + i.ToString() + "=" + j * i + Environment.NewLine;
                }
                tbCarpimTablosu.Text += Environment.NewLine;
            }
        }
    }
}

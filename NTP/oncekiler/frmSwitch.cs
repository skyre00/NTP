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
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void frmSwitch_Load(object sender, EventArgs e)
        {

        }

        private void btKontrol_Click(object sender, EventArgs e)
        {
            switch (tbDeger.Text)
            {
                case "5":MessageBox.Show("Pekiyi"); break;
                case "4": MessageBox.Show("İyi"); break;
                case "3": MessageBox.Show("Orta"); break;
                case "2": MessageBox.Show("Geçer"); break;
                case "1": MessageBox.Show("Başarısız"); break;
                default: MessageBox.Show("Geçersiz değer"); break;
            }
        }
    }
}

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
    public partial class frmSayiTahmin : Form
    {
        int min, max, rastgeleUretilen;
        public frmSayiTahmin()
        {
            InitializeComponent();
        }

        private void frmSayiTahmin_Load(object sender, EventArgs e)
        {
            ComboBoxaVerileriYukle();
            tbMin.Text = "50";
            tbMax.Text = "100";
            btUret_Click(null, null);
            lbTahminler.Text = "";
        }

        int sure = 0, dakika=0;

        private void frmSayiTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                kontrolEt();
            }
        }
        int okunan;
         void kontrolEt()
        {
            okunan = Convert.ToInt16(tbTahmininiz.Text);
            lbTahminler.Text += "--" + okunan.ToString();
            tbTahmininiz.Text = "";
            if (okunan<rastgeleUretilen)
            {
                pbYukari.Visible = true;
                pbAsagi.Visible = false;
                pbTamam.Visible = false;
            }
            else
            {
                if (okunan > rastgeleUretilen)
                {
                    pbYukari.Visible = false;
                    pbAsagi.Visible = true;
                    pbTamam.Visible = false;
                }
                else
                {
                    pbYukari.Visible = false;
                    pbAsagi.Visible = false;
                    pbTamam.Visible = true;
                }
            }
        }

        private void btUret_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            min = Convert.ToInt16(tbMin.Text);
            max = Convert.ToInt16(tbMax.Text);
            rastgeleUretilen = r.Next(min, max);

            this.Text = rastgeleUretilen.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { sure++;
            //lbGecenSure.Text = sure.ToString();

            if (sure%60==0)
            {
                dakika++;
                sure = 0;
            }
            if (dakika.ToString()=="0")
            {
                lbGecenSure.Text = "0"+dakika.ToString()+":"+ sure.ToString();
            }
            else
            {
                lbGecenSure.Text =  dakika.ToString() + ":" + sure.ToString();
            }
           


        }

        private void ComboBoxaVerileriYukle() // Turhancım burası fonksiyon ;)
        {
            for (int i = 1; i < 11; i++)
            {
                cbKacHakIstiyorsun.Items.Add(i);
            }

            cbKacHakIstiyorsun.SelectedText = "3"; // varsayılan olarak seçili gelmesi için 17/12/21
        }


    }
}

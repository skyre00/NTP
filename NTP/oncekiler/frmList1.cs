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
    public partial class frmList1 : Form
    {
        public frmList1()
        {
            InitializeComponent();
        }

        List<string> bilgi = new List<string>();
        public class ogrenci
        {
            public int numara;
            public string adi;
            public string soyadi;

        }

        ogrenci O = new ogrenci();

        List<ogrenci> bilgi2 = new List<ogrenci>();

        private void btEkle_Click(object sender, EventArgs e)
        {
            bilgi2.Add(new ogrenci
            {
                numara = Convert.ToInt16(tbNumara.Text),
                adi = tbIsim.Text,
                soyadi = tbSoyisim.Text
            }
            );



            bilgi.Add(tbNumara.Text + " " + tbIsim.Text + " " + tbSoyisim.Text);

            tbNumara.Text = tbIsim.Text = tbSoyisim.Text = null;
        }

        private void btAsagiEkle_Click(object sender, EventArgs e)
        {
            lbEklenenler.Items.Clear();

            for (int i = 0; i < bilgi.Count; i++)
            {
                lbEklenenler.Items.Add(bilgi[i]);
            }
        }

        private void btKacElemanVar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bilgi.Count.ToString());
        }

        private void btNumarayaGoreSirala_Click(object sender, EventArgs e)
        {
            lbEklenenler.Items.Clear(); // listboxun içini  rif gibi  temizledim :)
            bilgi.Sort();
            for (int i = 0; i < bilgi.Count; i++)
            {
                lbEklenenler.Items.Add(bilgi[i]);
            }

        }

        private void btIsmeGoreSiralaClassli_Click(object sender, EventArgs e)
        {
            lbEklenenler.Items.Clear();

            List<ogrenci> bilgi3 = new List<ogrenci>();

         bilgi3=bilgi2.OrderBy(c => c.adi).ToList();
            for (int i = 0; i < bilgi3.Count; i++)
            {
                lbEklenenler.Items.Add(bilgi3[i].numara+" "+bilgi3[i].adi + " "+ bilgi3[i].soyadi);
            }

        }

        private void btBilgileriOtomatikEkle_Click(object sender, EventArgs e)
        {
            bilgi2.Add(new ogrenci
            {
                numara = 1,
                adi = "İbrahim",
                soyadi = "Bağrıyanık"
            }
            );

            bilgi.Add("1" + " " + "İbrahim" + " " + "Bağrıyanık");
            bilgi2.Add(new ogrenci
            {
                numara = 10,
                adi = "Halil İbrahim",
                soyadi = "Terzi"
            }
          ); bilgi2.Add(new ogrenci
          {
              numara = 6,
              adi = "Emrah",
              soyadi = "Gözdendüşen"
          }
); bilgi.Add("6" + " " + "Emrah" + " " + "Gözdendüşen");
            bilgi2.Add(new ogrenci
            {
                numara = 9,
                adi = "Tyler",
                soyadi = "Durden"
            }
      );
            bilgi.Add("9" + " " + "Tyler" + " " + "Durden");
            bilgi.Add("10" + " " + "Halil İbrahim" + " " + "Terzi");
            bilgi2.Add(new ogrenci
            {
                numara = 112,
                adi = "Kartal",
                soyadi = "Kapanan"
            });
                        bilgi.Add("112" + " " + "Kartal" + " " + "Kapanan");

     bilgi2.Add(new ogrenci
     {
         numara = 113,
         adi = "Efe",
         soyadi = "Evin"
     }
      );
            bilgi.Add("113" + " " + "Efe" + " " + "Evin");

    


    //        bilgi.Add(tbNumara.Text + " " + tbIsim.Text + " " + tbSoyisim.Text);


        }

        private void btNumarayaGoreSiralaClassli_Click(object sender, EventArgs e)
        {

            lbEklenenler.Items.Clear();

            List<ogrenci> bilgi3 = new List<ogrenci>();

            bilgi3 = bilgi2.OrderBy(c => c.numara).ToList();
            for (int i = 0; i < bilgi3.Count; i++)
            {
                lbEklenenler.Items.Add(bilgi3[i].numara + " " + bilgi3[i].adi + " " + bilgi3[i].soyadi);
            }

        }

        private void btSoyismeGoreSiralaClassli_Click(object sender, EventArgs e)
        {

            lbEklenenler.Items.Clear();

            List<ogrenci> bilgi3 = new List<ogrenci>();

            bilgi3 = bilgi2.OrderBy(c => c.soyadi).ToList();
            for (int i = 0; i < bilgi3.Count; i++)
            {
                lbEklenenler.Items.Add(bilgi3[i].numara + " " + bilgi3[i].adi + " " + bilgi3[i].soyadi);
            }
        }
    }
}

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





    public partial class frmClass1 : Form
    {



        public frmClass1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void btOrnek_Click(object sender, EventArgs e)
        {
            //       int string

            //    int i=0;

            /* anahtar tanımlama */
            int i = new int();
            i = 0;

            char c = new char();
            c = 'a';

            string s = "muhasebe";



        }

        public class Dikdortgen
        {
            int a; int b;
            /// <summary>
            /// dikdörtgenin kenar uzunluklarını belirtiyoruz
            /// </summary>
            /// <param name="a">Kenar 1</param>
            /// <param name="b">Kenar 2</param>
            public Dikdortgen(int a, int b)
            {
                this.a = a; // yukardaki "int a" ile tanımlanan a'yı kullanmak için gerekli
                this.b = b;


                if (a * b > 2 * (a + b))
                    hangisi = "Alan çevreden büyük";
                else
                 if (2 * (a + b) > a * b)
                    hangisi = "Çevre alandan büyük";
                else hangisi = "Alan ve çevre birbirine eşit";


            }

            public int AlanHesapla()
            {
                return a * b;
            }


            public int CevreHesapla()
            {
                return 2 * (a + b);
            }

            /// <summary>
            /// alan ile çevre ilişkisini geriye döndürüyor
            /// </summary>
            public string hangisi;
        }

        private void btDikdortgen_Click(object sender, EventArgs e)
        {
            int i = new int();
            i = 5;
            Dikdortgen d = new Dikdortgen(5, 3);

            MessageBox.Show(d.AlanHesapla().ToString());
            MessageBox.Show(d.CevreHesapla().ToString());
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            int kenar1 = Convert.ToInt32(tbKenar1.Text), kenar2 = Convert.ToInt32(tbKenar2.Text);

            Dikdortgen d = new Dikdortgen(kenar1, kenar2);
            lbAlani.Text = d.AlanHesapla().ToString();
            lbCevresi.Text = d.CevreHesapla().ToString();
            lbSonDurum.Text = d.hangisi;

        }
    }



}

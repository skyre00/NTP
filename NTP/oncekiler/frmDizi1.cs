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
    public partial class frmDizi1 : Form
    {
        public frmDizi1()
        {
            InitializeComponent();
        }
        string ifade1, ifade2, ifade3;
        int kacAdet = 0, sayac = 0;

        private void frmDizi1_Load(object sender, EventArgs e)
        {
            lbGirilenDeger.Text = null;
            //   this.Text = frmDizi.aliEfe.ToString();
         
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            if (tbKacSayi.Text != null)
            {
                kacAdet = Convert.ToInt16(tbKacSayi.Text);

            }
            sayac++;
            if (sayac == 1)
            {
                ifade1 = tbIfade.Text;
                lbGirilenDeger.Text +=  " " + ifade1;
            }

          
            if (sayac == 2)
            {
                ifade2= tbIfade.Text;
                lbGirilenDeger.Text += " " + ifade2;
            }
       
            if (sayac == 3)
            {
                ifade3 = tbIfade.Text;
                lbGirilenDeger.Text += " " + ifade3;
            }


            if (sayac == kacAdet)
            {
                Hesapla();
            }

            


             
        }
        string ilkHarfler, IkinciHarfler;
        private void Hesapla()
        {
            ilkHarfler = ifade3[0].ToString() + ifade2[0].ToString() + ifade1[0].ToString();
            IkinciHarfler = ifade1[1].ToString() + ifade2[1].ToString() + ifade3[1].ToString();


            lbGirilenDeger.Text = "İlk harfler: " + ilkHarfler + " İkinci harfler:" + IkinciHarfler;
        }
    }
}

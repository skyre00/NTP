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
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void btOgrenciSayisi_Click(object sender, EventArgs e)
        {
        //    sinifim t = new sinifim();
         //   MessageBox.Show("Öğrenci sayısı: " + t.ogrenciSayisi);
        }

        private void btTopla_Click(object sender, EventArgs e)
        {
            // açıklama satırı oluyor 


            /*
      açıklama eğer birden fazla satırda olacaksa, / * * / işaretlerini kullanıyoruz      

    */



            // 10 ile 20 sayısını toplamak istiyorum. nasıl yol izlerim?    
            int a = 30;
            int b = 40;
            int c = a + b;
            MessageBox.Show(c.ToString());

            string isim = "Ergün Efe";
            MessageBox.Show(isim);



            char harf = 'a';
            MessageBox.Show(harf.ToString());



            bool mantik = true;
            MessageBox.Show(mantik.ToString());

            int aa, bb, cc;
        }
    }
}

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
    public partial class frmMantiksal : Form
    {
        public frmMantiksal()
        {
            InitializeComponent();
        }

        private void cbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGoster.Checked) tbSifre.PasswordChar = '\0';
            else tbSifre.PasswordChar = '*';
        }

        private void btKapat_Click(object sender, EventArgs e)
        {
            this.Dispose(); ///      this.Close(); bu da olabilir
        }
        private void btGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = tbKullaniciAdi.Text;
            string sifre = tbSifre.Text;
            string gercekKullaniciAdi = "recai";
            string gercekSifre = "123";
            if (kullaniciAdi == gercekKullaniciAdi && sifre == gercekSifre)
            {                frmRecai recai = new frmRecai();
                recai.Show();
                this.Visible = false;
            }
            else
            {
                if (tbKullaniciAdi.Text == "")
                    MessageBox.Show("Kullanıcı adını boş bıraktınız", "EKSİK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (tbSifre.Text == "")
                        MessageBox.Show("Şifreyi boş bıraktınız", "EKSİK", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                    {
                        if (kullaniciAdi == gercekKullaniciAdi && sifre != gercekSifre)
                            MessageBox.Show("Şifrenizi kontrol ediniz", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        else
                        {
                            if (kullaniciAdi != gercekKullaniciAdi && sifre == gercekSifre)
                                MessageBox.Show("Kullanıcı adınızı kontrol ediniz", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("Kullanıcı adı ve şifre bilginiz hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }


        }
    }

}

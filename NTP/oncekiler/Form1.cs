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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btAfilli.Text = "Afilli";
            btAfilli.BackColor = Color.Yellow;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona tıkladın!");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.Text = "Fare düğmenin üzerine geldi.";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Fare düğme üzerinden ayrıldı";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.CapsLock)
            {
                MessageBox.Show("Capslock tuşuna basıldı");
            }
        }

        private void btAfilli_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ben afilli bir mesajım","Mesajın başlığı burada",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        }
    }
}

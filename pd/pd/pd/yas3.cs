using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pd
{
    public partial class yas3 : Form
    {
        public yas3()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int kisiSayisi = 0;

            int yılfarkı = 2020 - 2015;
            int kalansayi = (10 * kisiSayisi) - (7 * (kisiSayisi + 10)) - yılfarkı;
            int islemsonucu = 75;
            int yasfarki = 3;
            kisiSayisi = islemsonucu / yasfarki;
            int sonuc = kisiSayisi * 10;


            label1.Text = sonuc.ToString();
            
        }
    }
}

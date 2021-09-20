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
    public partial class temelkav10 : Form
    {
        public temelkav10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisisayisi = 0;
            int sonuc = 1;
            int yılfarkı = 5;
            int kalansayi = (100 + (10 * kisisayisi) + kisisayisi - 100 * (-10 * kisisayisi) - kisisayisi) - yılfarkı;
            int islemsonucu = 36;
            int yasfarki = 5;
            kisisayisi = islemsonucu / yasfarki;
            sonuc = sonuc * 15;



            label1.Text = sonuc.ToString();
        }
    }
}

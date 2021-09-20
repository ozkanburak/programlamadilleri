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
    public partial class yas2 : Form
    {
        public yas2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisiSayisi;
            int enKucukYas = 1;
            int enBuyukYas = 92;
            int sonuc;
            int enKucukHaricOrtalama = 45;
            int enBuyukHaricOrtalama = 38;
            sonuc = (enBuyukYas - enKucukYas) / (enKucukHaricOrtalama - enBuyukHaricOrtalama);
            kisiSayisi = sonuc + 1;
            Console.WriteLine("Toplam Kişi Sayısı : " + kisiSayisi);
            

            label1.Text = kisiSayisi.ToString();
            
        }
    }
}

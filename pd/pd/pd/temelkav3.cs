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
    public partial class temelkav3 : Form
    {
        public temelkav3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int a = 0;
            double besgen;
            double dortgen;
            double ucgen;
            double cokgenformulu = (n * Math.Pow(n, a));
            double icindekisayi = 1;
            double sonuc;

            besgen = (5 * Math.Pow(icindekisayi, 5));

            dortgen = (4 * Math.Pow(icindekisayi, 4));

            ucgen = (3 * Math.Pow(icindekisayi, 3));
            sonuc = icindekisayi * Math.Pow(1, 4);
            sonuc = sonuc + 3 * Math.Pow(3, 4);
            Console.WriteLine(sonuc);

            label1.Text = sonuc.ToString();
           
        }
    }
}

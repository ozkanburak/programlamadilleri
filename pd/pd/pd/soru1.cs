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
    public partial class soru1 : Form
    {
        public soru1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char karakter1 = 'x';
            char karakter2 = 'y';
            int birinci = Math.Abs(((Convert.ToInt32(karakter1))));
            int ikinci = Math.Abs(((Convert.ToInt32(karakter2))));
            int sonuc1 = birinci * ikinci;
            Double sonuc2 = ikinci / birinci;



            double sonucyedek1 = 0;
            double sonucyedek2 = 0;

            if (sonuc1 >= 0)
            {
                sonucyedek1 = 2;

            }
            xdeger.Text = sonucyedek1.ToString();


            if (sonuc2 >= 0)
            {
                double bol = Convert.ToDouble(decimal.Divide(1, 3));
                sonucyedek2 = bol;

            }

            ydeger.Text = sonucyedek2.ToString();


            double sonsonuc = sonucyedek1 + sonucyedek2;


            sonuc.Text = sonsonuc.ToString();
            //sayın hocam karaterleri ascci koda aldığından direk çözüme göre kodladık

        }


    }
}
 
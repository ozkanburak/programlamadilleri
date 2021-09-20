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
    public partial class uslu4 : Form
    {
        public uslu4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 81;
            double b = 16;
            double c = 35;

            double d = a * b * c + a * b;
            double sonuc = d;

            double g = 6;
            double l = 6;


            Console.WriteLine(sonuc);
            
            label1.Text = sonuc.ToString();
            label2.Text = g.ToString();
            label4.Text = l.ToString();
        }
    }
}

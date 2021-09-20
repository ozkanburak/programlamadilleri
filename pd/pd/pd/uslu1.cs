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
    public partial class uslu1 : Form
    {
        public uslu1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Math.Pow(5, 3);
            double b = Math.Pow(2, 4);
            double c = Math.Pow(5, 4);
            double d = Math.Pow(2, 3);
            double k = 35;
            double f = a * b;
            double g = c * d;
            double h = f + g;
            double l = h / k;
            Console.WriteLine(l);

            label2.Text = h.ToString();
            label1.Text = l.ToString();
            label4.Text = k.ToString();
        }

        private void uslu1_Load(object sender, EventArgs e)
        {

        }
    }
}

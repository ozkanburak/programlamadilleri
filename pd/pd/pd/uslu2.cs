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
    public partial class uslu2 : Form
    {
        public uslu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Math.Pow(2, 12);
            double b = Math.Pow(5, 6);
            double c = Math.Pow(5, 6);
            double d = Math.Pow(2, 6);
            double k = a / b;
            double f = k * c * d;
            Console.WriteLine(f);

            double g = 18;
            double t = 2;
            
            
            label1.Text = f.ToString();
            label2.Text = t.ToString();
            label3.Text = g.ToString();
        }
    }
}

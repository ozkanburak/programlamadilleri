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
    public partial class koklu2 : Form
    {
        public koklu2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void koklu2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			double a = Math.Sqrt(Convert.ToInt32(tbxQ2a1.Text)) / Convert.ToInt32(tbxQ2a2.Text);
			double b = Math.Sqrt(Convert.ToInt32(tbxQ2b1.Text)) / Convert.ToInt32(tbxQ2b2.Text);
			double c = Math.Sqrt(Convert.ToInt32(tbxQ2c1.Text)) / Convert.ToInt32(tbxQ2c2.Text);

			lblQ2AS.Text += Decimal.Round(Convert.ToDecimal(a), 2).ToString();
			lblQ2BS.Text += Decimal.Round(Convert.ToDecimal(b), 2).ToString();
			lblQ2CS.Text += Decimal.Round(Convert.ToDecimal(c), 2).ToString();

			List<double> abc = new List<double>();
			abc.Add(a);
			abc.Add(b);
			abc.Add(c);
			abc.Sort();
			List<string> sonuc = new List<string>();
			foreach (var item in abc)
			{
				if (a == item) sonuc.Add("a");
				else if (b == item) sonuc.Add("b");
				else sonuc.Add("c");
			}
			lblQ2Sort.Text = sonuc[0] + " < " + sonuc[1] + " < " + sonuc[2];
		}
    }
}

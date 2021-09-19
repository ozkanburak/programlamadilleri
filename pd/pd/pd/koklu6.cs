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
    public partial class koklu6 : Form
    {
        public koklu6()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = Math.Sqrt(Convert.ToDouble(tbxQ611.Text));
            double value2 = Math.Sqrt(Convert.ToDouble(tbxQ612.Text));

            double eslenik1 = value1 + value2;
            double eslenik2 = value1 - value2;

            double result = (eslenik1 / eslenik2) - (eslenik1 * eslenik2);
            result *= result;
            lblQ6Sonuc.Text = Math.Round(result).ToString();
        }
    }
}

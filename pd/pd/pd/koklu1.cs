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
    public partial class koklu1 : Form
    {
        public koklu1()
        {
            InitializeComponent();
        }

        private void koklu1_Load(object sender, EventArgs e)
        {

        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            double degree = Convert.ToInt32(tbxQ1SqrDegree.Text);
            double value1 = Convert.ToInt32(tbxQ1V1.Text);
            double value2 = Convert.ToInt32(tbxQ1V2.Text);
            double value3 = Convert.ToInt32(tbxQ1V3.Text);

            double resultOfInsideOfRoot = value1 / (Math.Sqrt(value2) - Math.Sqrt(value3));
            var result = Math.Pow(resultOfInsideOfRoot, 1 / degree);
            lblQ1Sonuc.Text += result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

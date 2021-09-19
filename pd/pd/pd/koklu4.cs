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
    public partial class koklu4 : Form
    {
        public koklu4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int coloredSquareCount = Convert.ToInt32(tbxQ4BoyaliSAyi.Text);
            int totalSquareCount = Convert.ToInt32(tbxQ4Total.Text);
            double value = (Math.Sqrt(Convert.ToDouble(coloredSquareCount) / totalSquareCount) * totalSquareCount) - coloredSquareCount;
            lbl41.Text = "Sonuc: " + value.ToString();
        }
    }
    }


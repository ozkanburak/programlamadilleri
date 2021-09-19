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
    public partial class koklu3 : Form
    {
        public koklu3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double top = Convert.ToDouble(tbxQ3Top.Text);
            double bottom = Convert.ToDouble(tbxQ3Bottom.Text);
            double topSquare = top * top;
            double bottomSquare = bottom * bottom;

            lblQ3Bottom.Text = (bottomSquare + bottom).ToString();
            lblQ3Top.Text = (topSquare + bottom).ToString();
        }
    }
}

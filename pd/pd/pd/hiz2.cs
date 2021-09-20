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
    public partial class hiz2 : Form
    {
        public hiz2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, v;
            int t = 3;
            x = 100 * t;
            x = 60 * (t + 2);
            v = 300 / 4;

            label1.Text = v.ToString();
        }
    }
}

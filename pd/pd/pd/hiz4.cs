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
    public partial class hiz4 : Form
    {
        public hiz4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tx = 3;
            double t, t2; 
            t = (1.25); t2 = (2.5);
            double tur = (tx) - (t2);
            double sn = 60 * tur; 

            label1.Text = sn.ToString();
        }
    }
}

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
    public partial class soru4 : Form
    {
        public soru4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = 1.1;
            double l = 1.9;
            double sonuc = k * l;
            label1.Text = sonuc.ToString();
        }
    }
}

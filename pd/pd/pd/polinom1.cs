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
    public partial class polinom1 : Form
    {
        public polinom1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayi1 = 0;
            int p0 = (sayi1 * sayi1) - 1;
            int sayi2 = 1;
            int p1 = (sayi2 * sayi2) - 1;
            int sayi3 = -1;
            int p_1 = (sayi3 * sayi3) - 1;

            int sonuc = p_1;
            textBox1.Text = p_1.ToString();
        }
    }
}

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
    public partial class temelkav1 : Form
    {
        public temelkav1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = -2;
            int b = 2;
            int c = 2;
            int d = -2;
            int g = -2;
            int f = -2;
            int toplam;
            int carpım;
            int fark;

            fark = (a - b);
            carpım = (c * d);
            toplam = (g + f);
            if (fark == -4)
            {
                Console.WriteLine(fark);
            }
            if (carpım == -4)
            {
                Console.WriteLine(carpım);
            }
            if (toplam == -4)
            {
                Console.WriteLine(toplam);
            }

            label1.Text = toplam.ToString();
           
        }
}
}

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
    public partial class bolunebilme2 : Form
    {
        public bolunebilme2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 936;
            int sayi2 = 213;

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % 3 == 0 && sayi2 % sayi2 == 1)
                {
                    i = sayi - sayi2;

                    Console.WriteLine(i);

                    label1.Text=(936 - 213).ToString();
                }
    }

        }
    }
}

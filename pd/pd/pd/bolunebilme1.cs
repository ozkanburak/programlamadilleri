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
    public partial class bolunebilme1 : Form
    {
        public bolunebilme1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc = 0;
            
            sayi = Convert.ToInt32(Console.ReadLine());
            sayi = 333;
            sonuc += (sayi % 9);
            sayi = sayi / 9;

            
            
            label1.Text = sayi.ToString();
            label2.Text = (3 + 7).ToString();

        }
    }
}

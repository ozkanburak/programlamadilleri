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
    public partial class hiz1 : Form
    {
        public hiz1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, x1, x2; 
            int v;            
            int t;

            

            x1 = 120 * (8 / 60);
            
            x = 95 * (12 / 60);          
            x2 = 3;         
            v = x2 * (60 / 2);      
            Console.WriteLine(v);

            

            label1.Text = v.ToString();

        }
    }
}

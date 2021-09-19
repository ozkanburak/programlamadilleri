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
    public partial class koklusayi : Form
    {
        public koklusayi()
        {
            InitializeComponent();
        }

  
     

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            koklu1 ekle = new koklu1();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            koklu5 ekle = new koklu5();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            koklu6 ekle = new koklu6();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            koklu2 ekle = new koklu2();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            koklu3 ekle = new koklu3();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            koklu4 ekle = new koklu4();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
}

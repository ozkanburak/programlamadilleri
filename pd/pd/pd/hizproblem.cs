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
    public partial class hizproblem : Form
    {
        public hizproblem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hiz1 ekle = new hiz1();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hiz2 ekle = new hiz2();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            hiz4 ekle = new hiz4();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
}

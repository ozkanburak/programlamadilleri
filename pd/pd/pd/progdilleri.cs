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
    public partial class progdilleri : Form
    {
        public progdilleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mutlak ekle = new mutlak();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uslusayi ekle = new uslusayi();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koklusayi ekle = new koklusayi();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temelkavramlar ekle = new temelkavramlar();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bolmebolu ekle = new bolmebolu();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            polinom ekle = new polinom();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yasproblem ekle = new yasproblem();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hizproblem ekle = new hizproblem();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
    }
    


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
    public partial class temelkavramlar : Form
    {
        public temelkavramlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temelkav1 ekle = new temelkav1();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temelkav2 ekle = new temelkav2();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temelkav3 ekle = new temelkav3();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temelkav4 ekle = new temelkav4();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temelkav5 ekle = new temelkav5();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temelkav6 ekle = new temelkav6();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temelkav7 ekle = new temelkav7();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temelkav8 ekle = new temelkav8();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temelkav9 ekle = new temelkav9();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temelkav10 ekle = new temelkav10();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
}

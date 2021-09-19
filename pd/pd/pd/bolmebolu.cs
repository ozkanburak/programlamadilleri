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
    public partial class bolmebolu : Form
    {
        public bolmebolu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bolunebilme1 ekle = new bolunebilme1();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bolunebilme2 ekle = new bolunebilme2();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
}

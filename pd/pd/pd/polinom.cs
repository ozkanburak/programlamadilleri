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
    public partial class polinom : Form
    {
        public polinom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            polinom1 ekle = new polinom1();
            ekle.TopLevel = false;
            panel1.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        
    }
}

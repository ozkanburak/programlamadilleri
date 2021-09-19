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
    public partial class soru2 : Form
    {
        public soru2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double degergir = Convert.ToDouble(TextBox1.Text);
            double birincisayi = Convert.ToDouble(TextBox2.Text);
            double ikincisayi = Convert.ToDouble(TextBox3.Text);


            double sonuc1 = degergir + birincisayi;
            double sonuc2 = degergir + ikincisayi;

            double sonucbol = (sonuc1 + sonuc2) / 2;

            //MessageBox.Show(sonucbol.ToString());

            double soltaraf = sonuc1 - sonucbol;
            double sagtaraf = sonuc2 - sonucbol;

            sonuc.Text = soltaraf.ToString() + "<x-" + sonucbol + "<" + sagtaraf.ToString();

        }
    }
}

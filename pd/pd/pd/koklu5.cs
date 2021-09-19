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
    public partial class koklu5 : Form
    {
        public koklu5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            List<int> q5squares = new List<int>() { 5, 8, 12, 18, 20, 27 };
            while (q5squares.Count != 0)
            {
                total += q5islem(q5squares);
            }
            lblQ5Sonuc.Text += total.ToString();
        }
		private int q5islem(List<int> q5sqrs)
		{
			foreach (var i in q5sqrs)
			{
				foreach (var j in q5sqrs)
				{
					if (i != j)
					{
						for (int x = 0; x < 30; x++)
						{
							if ((i * j) == (x * x))
							{
								q5sqrs.Remove(i);
								q5sqrs.Remove(j);
								return Convert.ToInt32(Math.Sqrt(i * j));
							}
						}
					}
				}
			}
			return -1;
		}
	}
}

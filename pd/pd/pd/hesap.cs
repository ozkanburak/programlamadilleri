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
    public partial class hesap : Form
    {

        Double result = 0;
        String operation = "";
            bool enter_value = false;
        char iOperation;
        public hesap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;


            if ((txtDisplay.Text == "0") || (enter_value))
                    txtDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }



            
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(result !=0)
            {
                esit.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOp.Text = System.Convert.ToString(result) + "   " + operation;

            }
            else
            {
                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOp.Text = System.Convert.ToString(result) + "   " + operation;

            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            }
            if(txtDisplay.Text =="")
                    {
                txtDisplay.Text = "0";
            }
        }

        private void esit_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "X":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;

            }
            result = Double.Parse(txtDisplay.Text);
            operation = "";

        
    }
    }
}

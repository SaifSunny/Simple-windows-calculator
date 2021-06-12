using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Calculator
{
    public partial class Form1 : Form
    {
        double value;
        string op=" ";
        bool pressed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(pressed))
                result.Clear();
            pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            value = Convert.ToDouble(result.Text);
            pressed = true;
            equation.Text = value + " " + op;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            equation.Text=" ";
            switch (op)
            {
                case "+":
                    result.Text = Convert.ToString(value + Convert.ToDouble(result.Text)) ;
                    break;
                case "-":
                    result.Text = Convert.ToString(value - Convert.ToDouble(result.Text));
                    break;
                case "*":
                    result.Text = Convert.ToString(value * Convert.ToDouble(result.Text));
                    break;
                case "/":
                    result.Text = Convert.ToString(value / Convert.ToDouble(result.Text));
                    break;
                default:
                    break;
            }
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            result.Text="0";
            value = 0;
        }
    }
}

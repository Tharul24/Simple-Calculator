using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (tbDisplayresult.Text == "0" || (isOperationPerformed))
                tbDisplayresult.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;

            //validation on decimals more than 1
            if (button.Text == ".")
            {
                if (!tbDisplayresult.Text.Contains("."))
                    tbDisplayresult.Text += button.Text;
            }
            else
            {
                tbDisplayresult.Text += button.Text;
            }

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(tbDisplayresult.Text);
            lbCurrentOp.Text = resultValue +" " + operationPerformed;
            isOperationPerformed = true;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            tbDisplayresult.Text = "0";
            resultValue = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbDisplayresult.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                tbDisplayresult.Text = (resultValue + double.Parse(tbDisplayresult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                tbDisplayresult.Text = (resultValue - double.Parse(tbDisplayresult.Text)).ToString();
            }
            else if (operationPerformed == "x")
            {
                tbDisplayresult.Text = (resultValue * double.Parse(tbDisplayresult.Text)).ToString();
            }
            else
            {
                tbDisplayresult.Text = (resultValue / double.Parse(tbDisplayresult.Text)).ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tbDisplayresult.Text.Length > 0)
                tbDisplayresult.Text = tbDisplayresult.Text.Remove(tbDisplayresult.Text.Length - 1, 1);

            if (tbDisplayresult.Text == "")
                tbDisplayresult.Text = "0";
        }
    }
}

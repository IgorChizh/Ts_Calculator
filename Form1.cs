using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClikced = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (resBox.Text == "Let's count" || (isOperatorClikced) || resBox.Text == "0")
                resBox.Clear();

            isOperatorClikced = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if(!resBox.Text.Contains("."))
                    resBox.Text = resBox.Text + button.Text;
            }
            else
                resBox.Text = resBox.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                btnEql.PerformClick();
                operatorClicked = button.Text;
                isOperatorClikced = true;
            }
            else
            {
                operatorClicked = button.Text;
                resultValue = Double.Parse(resBox.Text);
                isOperatorClikced = true;
            }

            operatorClicked = button.Text;
            resultValue = Double.Parse(resBox.Text);
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            resBox.Text = "0";
            resultValue = 0;
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    resBox.Text = (resultValue + Double.Parse(resBox.Text)).ToString();
                    break;
                case "-":
                    resBox.Text = (resultValue - Double.Parse(resBox.Text)).ToString();
                    break;
                case "*":
                    resBox.Text = (resultValue * Double.Parse(resBox.Text)).ToString();
                    break;
                case "/":
                    resBox.Text = (resultValue / Double.Parse(resBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}

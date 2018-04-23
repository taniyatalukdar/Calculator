using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if((Result.Text == "0") || (isOperationPerformed))
            {
                Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;

            if(button.Text == ".")
            {
                if(!Result.Text.Contains("."))
                {
                    Result.Text = Result.Text + button.Text;
                }
            }
            else
            Result.Text = Result.Text + button.Text;
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                button10.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            { 
            operationPerformed = button.Text;
            resultValue = Double.Parse(Result.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            resultValue = 0;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    Result.Text = (resultValue + Double.Parse(Result.Text)).ToString();
                    break;

                case "-":
                    Result.Text = (resultValue - Double.Parse(Result.Text)).ToString();
                    break;

                case "*":
                    Result.Text = (resultValue * Double.Parse(Result.Text)).ToString();
                    break;

                case "/":
                    Result.Text = (resultValue / Double.Parse(Result.Text)).ToString();
                    break;
            }

            resultValue = Double.Parse(Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}

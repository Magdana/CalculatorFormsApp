using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormsApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            historyBox.ReadOnly = true;
            inputBox.KeyPress += DisableKeyboardInput;
            historyBox.KeyPress += DisableKeyboardInput;
            historyBox.Enabled = false;
        }

        double currentNum = 0;
        double result = 0;
        string mathOperator = "";
        bool isOperatorClicked = false;
        bool isResultDisplayed = false;

        private void DisableKeyboardInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void AppendNumber(string number)
        {
            if (isOperatorClicked || isResultDisplayed)
            {
                inputBox.Text = "";
                isOperatorClicked = false;

                if (isResultDisplayed)
                {
                    historyBox.Text = "";
                    isResultDisplayed = false;
                }
            }
            inputBox.Text += number;
            historyBox.Text += number;
        }



        private void seven_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void four_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void one_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (!inputBox.Text.Contains("."))
            {
                AppendNumber(".");
            }
        }


        private void SetOperator(string operatorSymbol)
        {
            if (double.TryParse(inputBox.Text, out currentNum))
            {
                if (result == 0)
                    result = currentNum;
                else
                    CalculateResult();

                mathOperator = operatorSymbol;
                isOperatorClicked = true;
                isResultDisplayed = false;
                inputBox.Text = "";
                historyBox.Text = result.ToString() + " " + mathOperator + " ";
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            SetOperator("/");
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            SetOperator("*");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }



        private void equation_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputBox.Text, out currentNum))
            {
                CalculateResult();
                if (inputBox.Text != "Error: Division by zero!")
                {
                    inputBox.Text = result.ToString();
                    isResultDisplayed = true;
                }
                result = 0;
                mathOperator = "";
            }
        }



        private void CalculateResult()
        {
            switch (mathOperator)
            {
                case "+":
                    result += currentNum;
                    break;
                case "-":
                    result -= currentNum;
                    break;
                case "*":
                    result *= currentNum;
                    break;
                case "/":
                    if (currentNum == 0)
                    {
                        inputBox.Text = "Error: Division by zero!";
                        result = 0;
                        return;
                    }
                    else
                    {
                        result /= currentNum;
                    }
                    break;
            }
        }

        private void erase1_Click(object sender, EventArgs e)
        {
            result = 0;
            mathOperator = "";
            inputBox.Text = "";
            historyBox.Text = "";
        }

        private void erase2_Click(object sender, EventArgs e)
        {
            result = 0;
            mathOperator = "";
            inputBox.Text = "";
            historyBox.Text = "";
        }

        private void ToggleSign()
        {
            if (double.TryParse(inputBox.Text, out currentNum))
            {
                currentNum = -currentNum;
                inputBox.Text = currentNum.ToString();

                if (isResultDisplayed)
                {
                    historyBox.Text = currentNum.ToString();
                    isResultDisplayed = false; 
                }
            }
        }
        private void toggleSignButton_Click(object sender, EventArgs e)
        {
            ToggleSign();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private string Operation;
        private bool IsOperatorClicked = false;

        /// <summary>
        /// Calculatorクラスのコンストラクタ
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }
        
        private int CheckIsOperator()
        {
            string currentText = textDisplay.Text;
            int lastOperatorIndex = Math.Max(currentText.LastIndexOf("+"),
                    Math.Max(currentText.LastIndexOf("-"),
                    Math.Max(currentText.LastIndexOf("x"),
                    currentText.LastIndexOf("÷"))));
            return lastOperatorIndex;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;

            if (currentText.StartsWith("-"))
            {
                textDisplay.Text = currentText.Substring(1);
            }
            else
            {
                textDisplay.Text = "-" + currentText;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            resultDisplay.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            Button dot = (Button)sender;
            string currentText = textDisplay.Text;
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";

            if ("+-x÷.".Contains(lastChar))
            {
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1) + dot.Text;
            }
            else
            {
                textDisplay.Text += dot.Text;
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;

            if (double.TryParse(currentText, out double inputValue))
            {
                double percentValue = inputValue / 100;
                textDisplay.Text = CheckPercentResult(percentValue);
            }
            else
            {
                if (CheckIsOperator() != -1)
                {
                    string lastNumber = currentText.Substring(CheckIsOperator() + 1);
                    if (double.TryParse(lastNumber, out double lastValue))
                    {
                        double percentValue = lastValue / 100;
                        textDisplay.Text = currentText.Substring(0, CheckIsOperator() + 1) + CheckPercentResult(percentValue);
                    }
                }
            }
        }

        private string CheckPercentResult(double Value)
        {
            decimal decimalValue = (decimal)Value;
            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits(decimalValue)[3])[2];

            if (decimalPlaces < 10)
            {
                return decimalValue.ToString("F10").TrimEnd('0');
            }
            else if (decimalPlaces < 28)
            {
                return decimalValue.ToString("G10");
            }
            else
            {
                textDisplay.Text = "Error";
                return textDisplay.Text;
            }
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (textDisplay.Text == "0")
            {
                textDisplay.Clear();
            }
            textDisplay.Text += num.Text;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button opr = (Button)sender;
            Operation = opr.Text;
            string currentText = textDisplay.Text;
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";

            if ("+-x÷.".Contains(lastChar))
            {
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1) + Operation;
            }
            else if (currentText.Equals("") && !IsOperatorClicked)
            {
                textDisplay.Clear();
            }
            else
            {
                textDisplay.Text += Operation;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";
            if ("+-x÷.".Contains(lastChar))
            {
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1);
            }

            string equation = textDisplay.Text;
            equation = equation.Replace("/", "÷").Replace("*", "x");

            try
            {
                var result = new DataTable().Compute(equation.Replace("÷", "/").Replace("x", "*"), null);

                if (equation.Contains("÷0") && !equation.Contains("÷0."))
                {
                    resultDisplay.Text = "Error";
                    textDisplay.Clear();
                }
                else
                {
                    textDisplay.Text = result.ToString();
                    resultDisplay.Text = "=" + textDisplay.Text;
                }
            }
            catch (DivideByZeroException)
            {
                resultDisplay.Text = "Error";
                textDisplay.Clear();
            }
        }
    }
}

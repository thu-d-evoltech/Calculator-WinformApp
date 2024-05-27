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
        private bool IsDotClicked = false;
        private double NegateValue = 0;
        private double PercentValue = 0;

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
            /*double number;
            if (displayText.Text == "0.")
            {
                displayText.Text = "-0.";
                pointCheck = true;
            }
            else if (displayText.Text.EndsWith("."))
            {
                number = Double.Parse(displayText.Text) * (-1.0);
                displayText.Text = System.Convert.ToString(number) + ".";
            }
            else
            {
                number = Double.Parse(displayText.Text) * (-1.0);
                displayText.Text = System.Convert.ToString(number);
            }*/

            string currentText = textDisplay.Text;
            if (currentText == "0.")
            {
                textDisplay.Text = "-0.";
            }
            else if (double.TryParse(currentText, out double inputValue))
            {
                NegateValue = -inputValue;
                textDisplay.Text = NegateValue.ToString();
            }
            else
            {
                if (CheckIsOperator() != -1)
                {
                    string lastNumber = currentText.Substring(CheckIsOperator() + 1);
                    if (double.TryParse(lastNumber, out double lastValue))
                    {
                        NegateValue = -lastValue;
                        textDisplay.Text = $"{currentText.Substring(0, CheckIsOperator() + 1)}({NegateValue})";
                    }
                }
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

            if (double.TryParse(currentText, out double inputValue) && !currentText.Contains("."))
            {
                textDisplay.Text = inputValue + dot.Text;
            }
            else
            {
                if (CheckIsOperator() != -1)
                {
                    string lastNumber = currentText.Substring(CheckIsOperator() + 1);
                    if (double.TryParse(lastNumber, out double lastValue) && !lastNumber.Contains("."))
                    {
                        textDisplay.Text = $"{currentText.Substring(0, CheckIsOperator() + 1)}{lastValue}{dot.Text}";
                    }
                }
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;
            int openParenthes = currentText.LastIndexOf("(");

            if (double.TryParse(currentText, out double inputValue))
            {
                PercentValue = inputValue / 100;
                textDisplay.Text = CheckPercentResult(PercentValue);
            }
            else
            {
                string lastNumber = currentText.Substring(CheckIsOperator() + 1);
                if (CheckIsOperator() != -1)
                {
                    if (double.TryParse(lastNumber, out double lastValue))
                    {
                        PercentValue = lastValue / 100;
                        textDisplay.Text = $"{currentText.Substring(0, CheckIsOperator() + 1)}({CheckPercentResult(PercentValue)})";
                    }
                    else if (openParenthes != -1)
                    {
                        int closeParenthes = currentText.IndexOf(")", openParenthes);
                        if (closeParenthes != -1)
                        {
                            string numberInParentheses = currentText.Substring(openParenthes + 1, closeParenthes - openParenthes - 1);
                            if (double.TryParse(numberInParentheses, out double valueInParentheses))
                            {
                                PercentValue = valueInParentheses / 100;
                                textDisplay.Text = $"{currentText.Substring(0, openParenthes + 1)}{CheckPercentResult(PercentValue)}{currentText.Substring(closeParenthes)}";
                            }
                        }
                    }
                }
            }
        }

        private string CheckPercentResult(double Value)
        {
            if (Math.Abs(Value) < 1e-10)
            {
                return Value.ToString("G10");
            }
            else
            {
                return Value.ToString("F20").TrimEnd('0').TrimEnd('.');
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
            if ("+-x÷".Contains(lastChar))
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// Calculatorクラスのコンストラクタ
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }
        string Operation;

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            string inputValue = textDisplay.Text;

            if (inputValue.StartsWith("-"))
            {
                textDisplay.Text = inputValue.Substring(1);
            }
            else
            {
                textDisplay.Text = "-" + inputValue;
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
            string currentValue = textDisplay.Text;

            int lastOperatorIndex = Math.Max(currentValue.LastIndexOf("+"),
                Math.Max(currentValue.LastIndexOf("-"),
                Math.Max(currentValue.LastIndexOf("x"),
                currentValue.LastIndexOf("÷"))));

            if (lastOperatorIndex == -1)
            {
                if (double.TryParse(currentValue, out double inputValue))
                {
                    double percentValue = inputValue / 100;
                    textDisplay.Text = percentValue.ToString();
                }
            }
            else
            {
                string lastNumber = currentValue.Substring(lastOperatorIndex + 1);
                if (double.TryParse(lastNumber, out double lastValue))
                {
                    double percentValue = lastValue / 100;
                    textDisplay.Text = currentValue.Substring(0, lastOperatorIndex + 1) + percentValue.ToString();
                }
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
            else if (currentText.Equals("") && (Operation.Contains("÷") || Operation.Contains("x")))
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

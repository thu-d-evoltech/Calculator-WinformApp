using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private bool IsOperatorClicked = false;

        /// <summary>
        /// 
        /// </summary>
        private bool IsNumberClicked = false;

        /// <summary>
        /// 
        /// </summary>
        private double NegateValue = 0;

        /// <summary>
        /// 
        /// </summary>
        private double PercentValue = 0;

        /// <summary>
        /// 
        /// </summary>
        private const int MaxNumberLength = 13;

        /// <summary>
        /// Calculatorクラスのコンストラクタ
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int CheckIsOperator()
        {
            string currentText = textDisplay.Text;
            int lastOperatorIndex = Math.Max(currentText.LastIndexOf("+"),
                    Math.Max(currentText.LastIndexOf("-"),
                    Math.Max(currentText.LastIndexOf("x"),
                    currentText.LastIndexOf("÷"))));
            return lastOperatorIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNegate_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;
            if (currentText.EndsWith(".") && CheckIsOperator() == -1)
            {
                textDisplay.Text = "-" + currentText;
            }
            else if (double.TryParse(currentText, out double inputValue))
            {
                NegateValue = -inputValue;
                textDisplay.Text = NegateValue.ToString();
            }
            else if (CheckIsOperator() != -1)
            {
                string lastNumber = currentText.Substring(CheckIsOperator() + 1);
                    if (lastNumber.EndsWith("."))
                    {
                        textDisplay.Text = $"{currentText.Substring(0, CheckIsOperator() + 1)}-{lastNumber}";
                    }
                    else if (double.TryParse(lastNumber, out double lastValue))
                    {
                        NegateValue = -lastValue;
                        textDisplay.Text = $"{currentText.Substring(0, CheckIsOperator() + 1)}{NegateValue}";
                    }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            resultDisplay.Text = "0";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "0";
            }
            textDisplay.Text += num.Text;
            IsNumberClicked = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button opr = (Button)sender;
            string currentText = textDisplay.Text;
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";

            if ("+-x÷.".Contains(lastChar))
            {
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1) + opr.Text;
            }
            else if (currentText.Equals("") && !IsOperatorClicked)
            {
                textDisplay.Clear();
            }
            else
            {
                textDisplay.Text += opr.Text;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                else if (equation.Contains("÷0") && !IsNumberClicked)
                {
                    resultDisplay.Text = "Error";
                    textDisplay.Clear();
                }
                else
                {
                    textDisplay.Text = result.ToString().TrimEnd('0');
                    if (textDisplay.Text == "")
                    {
                        textDisplay.Text = "0";
                    }
                    resultDisplay.Text = "=" + textDisplay.Text;
                }
            }
            catch (DivideByZeroException)
            {
                resultDisplay.Text = "Error";
                textDisplay.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textDisplay_TextChanged(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;
            string[] parts = currentText.Split(new char[] { '+', '-', 'x', '÷', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                // 
                if (part.All(char.IsDigit))
                {
                    // 
                    if (part.Length > MaxNumberLength)
                    {
                        //
                        textDisplay.Text = currentText.Replace(part, part.Substring(0, MaxNumberLength));
                        textDisplay.SelectionStart = currentText.Length;
                        break;
                    }
                }
            }
        }
    }
}

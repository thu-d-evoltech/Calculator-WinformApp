using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private string Operator;

        /// <summary>
        /// 演算子ボタンがクリックされたチェック
        /// </summary>
        private bool IsOperatorClicked = false;

        /// <summary>
        /// ネガティブ値
        /// </summary>
        private double NegateValue = 0;

        /// <summary>
        /// パーセントの結果
        /// </summary>
        private double PercentValue = 0;

        /// <summary>
        /// 最大の数値の桁数
        /// </summary>
        private const int MaxNumberLength = 10;

        /// <summary>
        /// Calculatorクラスのコンストラクタ
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// テキストから最後の演算子の位置を検索す
        /// </summary>
        /// <returns>最後の演算子の位置。見つからない場合は-1</returns>
        private int CheckLastOperator()
        {
            string currentText = textDisplay.Text;

            // '+'、'-'、'x'、'÷'の各演算子が最位置を検索し、
            // 最後に出現する演算子の位置を見つける
            int lastOperatorIndex = Math.Max(currentText.LastIndexOf("+"),
                    Math.Max(currentText.LastIndexOf("-"),
                    Math.Max(currentText.LastIndexOf("x"),
                    currentText.LastIndexOf("÷"))));

            // 最後の演算子の位置を返す
            return lastOperatorIndex;
        }

        /// <summary>
        /// テキストボックスの最後の文字を削除するボタン
        /// </summary>
        /// <param name="sender">イベントの発生元</param>
        /// <param name="e">イベント引数</param>
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

            if (currentText.EndsWith(".") && CheckLastOperator() == -1)
            {
                textDisplay.Text = "-" + currentText;
            }
            else if (double.TryParse(currentText, out double inputValue))
            {
                NegateValue = -inputValue;
                textDisplay.Text = NegateValue.ToString();
            }
            else if (CheckLastOperator() != -1)
            {
                string lastNumber = currentText.Substring(CheckLastOperator() + 1);

                if (currentText[CheckLastOperator()] != '-')
                {
                    if (lastNumber.Contains("."))
                    {
                        textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}-{lastNumber}";
                    }
                    else if (double.TryParse(lastNumber, out double lastValue))
                    {
                        NegateValue = -lastValue;
                        textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}{NegateValue}";
                    }
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
                if (CheckLastOperator() != -1)
                {
                    string lastNumber = currentText.Substring(CheckLastOperator() + 1);
                    if (double.TryParse(lastNumber, out double lastValue) && !lastNumber.Contains("."))
                    {
                        textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}{lastValue}{dot.Text}";
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
                string lastNumber = currentText.Substring(CheckLastOperator() + 1);
                if (CheckLastOperator() != -1)
                {
                    if (double.TryParse(lastNumber, out double lastValue))
                    {
                        PercentValue = lastValue / 100;
                        textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}({CheckPercentResult(PercentValue)})";
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
            string currentText = textDisplay.Text;
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";
            if (textDisplay.Text == "0")
            {
                textDisplay.Clear();
            }
            else if ("0".Contains(lastChar) && !currentText.Contains(".") && currentText.Contains("÷"))
            {
                return;
            }
            textDisplay.Text += num.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button opr = (Button)sender;
            Operator = opr.Text;
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
                double result = Convert.ToDouble(new DataTable().Compute(equation.Replace("÷", "/").Replace("x", "*"), null));

                if (equation.Contains("÷0") && !equation.Contains("÷0."))
                {
                    resultDisplay.Text = "Error";
                    textDisplay.Clear();
                }
                else
                {
                    textDisplay.Text = CheckPercentResult(result);
                    
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

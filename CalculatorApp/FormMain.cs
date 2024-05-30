using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// 各演算子ボタン
        /// </summary>
        private string Operator;

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
        private const int MaxNumberLength = 13;

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
        /// 与えられた数値の結果をチェックし、適切な形式で文字列に変換する
        /// </summary>
        /// <param name="Value">チェックする数値</param>
        /// <returns>適切な形式の文字列に変換した結果</returns>
        private string CheckResult(double Value)
        {
            if (Math.Abs(Value) < 1e-10)
            {
                // 数値の絶対値は1e-10より小さい場合、数値は指数として返す
                return Value.ToString("G10");
            }
            else
            {
                // それ以外の場合、数値は10進数として返す
                // 不要な末尾のゼロと小数点を削除す
                return Value.ToString("F20").TrimEnd('0').TrimEnd('.');
            }
        }

        /// <summary>
        /// テキストボックスの最後の文字を削除するボタン
        /// </summary>
        /// <param name="sender">イベントの発生元</param>
        /// <param name="e">イベント引数</param>
        private void buttonDel_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;

            // 文字列の最後の値を検索する
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";

            if (")".Contains(lastChar))
            {
                return;
            }
            else if (currentText.Length > 0)
            {
                // 最後の文字を削除
                textDisplay.Text = currentText.Remove(currentText.Length - 1, 1);
            }
        }

        /// <summary>
        /// ネガティブボタンがクリックされたときの処理を実行する
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void buttonNegate_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;

            // 小数点で終わっていて最後の演算子が存在しない場合、先頭にマイナスを追加
            if (currentText.EndsWith(".") && CheckLastOperator() == -1)
            {
                textDisplay.Text = "-" + currentText;
            }
            // テキストボックスで数値として解釈できる場合、その値の符号を反転
            else if (double.TryParse(currentText, out double inputValue))
            {
                NegateValue = -inputValue;
                if (currentText.StartsWith("-"))
                {
                    textDisplay.Text = currentText.Substring(1);
                }
                else
                {
                    textDisplay.Text = NegateValue.ToString();
                }
            }
            // テキストボックスで演算子もある場合
            else if (CheckLastOperator() != -1)
            {
                // 最後の演算子の後の値
                string lastNumber = currentText.Substring(CheckLastOperator() + 1);

                // 最後の演算子の前に別の演算子が存在しない場合
                if (currentText[CheckLastOperator() - 1].ToString() != Operator)
                {
                    if (lastNumber.Contains("."))
                    {
                        // 最後の演算子の後の値に小数点が含まれる場合、値の前にマイナス記号を追加する
                        textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}-{lastNumber}";
                    }
                    else if (double.TryParse(lastNumber, out double lastValue))
                    {
                        // 最後の演算子の後の値は数値として解釈できる場合、その値の符号を反転
                        NegateValue = -lastValue;
                        textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}{NegateValue}";
                    }
                }
                else
                {
                    // 最後の演算子の前に別の演算子が存在する場合、マイナス記号を削除する
                    textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator())}{lastNumber}";
                }
            }
        }

        /// <summary>
        /// ボタン「C」がクリックされたときの処理を実行する
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            resultDisplay.Text = "0";
        }

        /// <summary>
        /// 小数点ボタンがクリックされたときの処理を実行する
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void buttonDot_Click(object sender, EventArgs e)
        {
            Button dot = (Button)sender;
            string currentText = textDisplay.Text;

            // 数値として解釈でき、かつまだ小数点が含まれていない場合、小数点を追加する
            if (double.TryParse(currentText, out double inputValue) && !currentText.Contains("."))
            {
                textDisplay.Text = inputValue + dot.Text;
            }
            // テキストボックスで演算子もある場合
            else if (CheckLastOperator() != -1)
            {
                // 最後の演算子の後の値
                string lastNumber = currentText.Substring(CheckLastOperator() + 1);

                // 最後の演算子の後の値は数値として解釈でき、かつまだ小数点が含まれていない場合場合、小数点を追加する
                if (double.TryParse(lastNumber, out double lastValue) && !lastNumber.Contains("."))
                {
                    textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}{lastValue}{dot.Text}";
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
                textDisplay.Text = CheckResult(PercentValue);
            }
            else
            {
                string lastNumber = currentText.Substring(CheckLastOperator() + 1);
                if (CheckLastOperator() != -1)
                {
                    if (double.TryParse(lastNumber, out double lastValue))
                    {
                        PercentValue = lastValue / 100;
                        textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}({CheckResult(PercentValue)})";
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
                                textDisplay.Text = currentText.Substring(0, openParenthes + 1) + 
                                    CheckResult(PercentValue) + currentText.Substring(closeParenthes);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 数字ボタンがクリックされたときの処理を実行する
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            string currentText = textDisplay.Text;

            // 文字列の最後の値を検索する
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";

            // テキストが「0」の場合、クリア
            if (textDisplay.Text == "0")
            {
                textDisplay.Clear();
            }
            // 最後の文字が「0」で、まだ小数点が含まれておらず、かつ「÷」が含まれている場合、数字を入力出来ない
            else if ("0".Contains(lastChar) && !currentText.Contains(".") && currentText.Contains("÷"))
            {
                return;
            }

            // ボタンのテキストをテキストボックスに追加
            textDisplay.Text += num.Text;
        }

        /// <summary>
        /// 演算子ボタンがクリックされたときの処理を実行する
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button opr = (Button)sender;

            // ボタンのテキストを Operator 変数に格納します。
            Operator = opr.Text;
            string currentText = textDisplay.Text;

            // 文字列の最後の値を検索する
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";

            // 最後の文字が演算子または小数点の場合、疎の演算を新しい演算子で置き換える
            if ("+-x÷.".Contains(lastChar))
            {
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1) + opr.Text;
            }
            // テキストボックスが空の場合、演算子を入力出来ない
            else if (currentText.Equals(""))
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
            else if (currentText == "")
            {
                return;
            }

            string equation = textDisplay.Text;
            equation = equation.Replace("/", "÷").Replace("*", "x");

            try
            {
                double result = Convert.ToDouble(new DataTable().Compute(equation.Replace("÷", "/").Replace("x", "*"), null));
                /*if (lastChar.Contains("E"))
                {
                    // Tính giá trị của số e
                    double eValue = Math.Exp(1);
                    // Thay thế "E" bằng giá trị của số e
                    equation = equation.Replace("E", eValue.ToString());
                    result = Convert.ToDouble(new DataTable().Compute(equation.Replace("÷", "/").Replace("x", "*"), null));
                }
                else
                {
                    result = Convert.ToDouble(new DataTable().Compute(equation.Replace("÷", "/").Replace("x", "*"), null));
                }*/

                if (equation.Contains("÷0") && !equation.Contains("÷0."))
                {
                    resultDisplay.Text = "Error";
                    textDisplay.Clear();
                }
                else
                {
                    textDisplay.Text = CheckResult(result);
                    resultDisplay.Text = "=" + textDisplay.Text;
                }
            }
            catch (DivideByZeroException)
            {
                resultDisplay.Text = "Error";
                textDisplay.Clear();
            }
            catch (OverflowException)
            {
                resultDisplay.Text = "数字が大きすぎます";
                textDisplay.Clear();
            }
        }

        /// <summary>
        /// テキストボックスの内容が変更されたときに呼び出されるイベントハンドラー。
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void textDisplay_TextChanged(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;

            // テキストを演算子と小数点で分割し、空の部分は除外する
            string[] parts = currentText.Split(new char[] { '+', '-', 'x', '÷'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                // 部分が数字のみで構成されているかをチェックする
                if (part.All(char.IsDigit))
                {
                    // 数字の長さが最大許容長を超えているかをチェックする
                    if (part.Length > MaxNumberLength)
                    {
                        // 最大許容長を超える部分を切り取り、テキストボックスのテキストを表示する
                        textDisplay.Text = currentText.Replace(part, part.Substring(0, MaxNumberLength));
                        break;
                    }
                }
            }
            // テキストボックスの選択範囲をテキストの最後に設定し、カーソルをスクロールさせる
            textDisplay.Select(textDisplay.Text.Length, 0);
            textDisplay.ScrollToCaret();
        }
    }
}

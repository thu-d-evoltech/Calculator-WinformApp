using System;
using System.Data;
using System.Drawing;
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
        /// 元のフォントサイズ
        /// </summary>
        private float OriginalFontSize;

        /// <summary>
        /// 等号がクリックしたチェック
        /// </summary>
        private bool EqualsClicked = false;

        /// <summary>
        /// 計算の結果
        /// </summary>
        private double Result;

        /// <summary>
        /// Calculatorクラスのコンストラクタ
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
            OriginalFontSize = textDisplay.Font.Size;
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
            if (Math.Abs(Value) < 1e-10 || Math.Abs(Value) > 1e12)
            {
                // 数値の絶対値は "1e-10" より小さい場合、数値は指数として返す
                return Value.ToString("G10");
            }
            else
            {
                // それ以外の場合、数値は10進数として返す
                // 不要な末尾の "0"と小数点を削除す
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

            // 最後の文字が右括弧の場合は削除できない
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
            if (currentText.Contains(".") && CheckLastOperator() == -1)
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

            // フォントサイズが小さくなっている場合、「C」ボタンを押すと最初のサイズを戻る
            textDisplay.Font = new Font(textDisplay.Font.FontFamily, OriginalFontSize, textDisplay.Font.Style);
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
            if (double.TryParse(currentText, out double inputValue) && !currentText.Contains(".") && !currentText.Contains("E"))
            {
                textDisplay.Text = inputValue + dot.Text;
            }
            // テキストボックスで演算子もある場合
            else
            {
                // 最後の演算子の後の値
                string lastNumber = currentText.Substring(CheckLastOperator() + 1);

                // 最後の演算子の後の値は数値として解釈でき、かつまだ小数点が含まれていない場合場合、小数点を追加する
                if (double.TryParse(lastNumber, out double lastValue) && !lastNumber.Contains(".") && !currentText.Contains("E"))
                {
                    textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}{lastValue}{dot.Text}";
                }
            }
        }

        /// <summary>
        /// パーセントボタンがクリックされたときの処理を実行する
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;

            // 最後の開き括弧の位置の変数
            int openParenthes = currentText.LastIndexOf("(");

            // 現在のテキストが数値に変換できる場合、その数値のパーセントを計算する
            if (double.TryParse(currentText, out double inputValue))
            {
                PercentValue = inputValue / 100;
                textDisplay.Text = CheckResult(PercentValue);
            }
            else
            {
                // 最後の演算子の後の数字を取得
                string lastNumber = currentText.Substring(CheckLastOperator() + 1);

                // 最後の演算子の後の数字が数値に変換できる場合、その数値のパーセントを計算する
                if (double.TryParse(lastNumber, out double lastValue))
                {
                    PercentValue = lastValue / 100;

                    // パーセンテージの結果を括弧内に入れて、テキストボックスに表示す
                    textDisplay.Text = $"{currentText.Substring(0, CheckLastOperator() + 1)}({CheckResult(PercentValue)})";
                }
                // 開き括弧がある場合
                else if (openParenthes != -1)
                {
                    // 対応する閉じ括弧の位置を見つける
                    int closeParenthes = currentText.IndexOf(")", openParenthes);
                    if (closeParenthes != -1)
                    {
                        // 閉じ括弧を見つける場合、括弧内の数字を取得
                        string numberInParentheses = currentText.Substring(openParenthes + 1, closeParenthes - openParenthes - 1);

                        // その括弧内の数字のパーセントを計算する
                        if (double.TryParse(numberInParentheses, out double valueInParentheses))
                        {
                            PercentValue = valueInParentheses / 100;

                            // パーセンテージの結果を括弧内に入れて、テキストボックスに表示す
                            textDisplay.Text = currentText.Substring(0, openParenthes + 1) + CheckResult(PercentValue) + currentText.Substring(closeParenthes);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 等しいボタンがクリックされたときの処理を実行する
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string currentText = textDisplay.Text;

            // 文字列の最後の値を検索する
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";

            if ("+-x÷".Contains(lastChar))
            {
                // 最後の文字は演算子の場合、その演算子を削除する
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1);
            }
            // 現在のテキストが空の場合、処理を中断する
            else if (currentText == "")
            {
                return;
            }

            // 計算式を準備します。"/"と"*"をそれぞれフォームの"÷"と"x"に置換する
            string equation = textDisplay.Text;
            equation = equation.Replace("/", "÷").Replace("*", "x");

            try
            {
                // 最後の文字が"E"を含む場合、数値eの値を計算し、"E"をその値に置換します。
                if (lastChar.Contains("E"))
                {
                    // 最後の文字が"E"を含む場合、"E"の値を計算する
                    equation = equation.Replace("E", $"*{Math.Exp(1)}");
                }

                // データベースのテーブルのようにデータを格納するための DataTable クラスを使用する
                // そのデータを計算するために Compute メソッドを使用して、結果をdouble型で取得する
                Result = Convert.ToDouble(new DataTable().Compute(equation.Replace("÷", "/").Replace("x", "*"), null));

                if (double.IsPositiveInfinity(Result) || double.IsNegativeInfinity(Result) || double.IsNaN(Result))
                {
                    // 結果が無限大または NaN の場合はメッセージを表示する
                    resultDisplay.Text = "Error";
                    textDisplay.Clear();
                }
                else
                {
                    resultDisplay.Text = "=" + CheckResult(Result);
                }
            }
            // 0 による除算の例外を処理する
            catch (DivideByZeroException)
            {
                resultDisplay.Text = "Error";
                textDisplay.Clear();
            }
            // 結果がデータ型の範囲を超えた例外を処理する
            catch (OverflowException)
            {
                resultDisplay.Text = "数字が大きすぎます";
                textDisplay.Clear();
            }
            // 文字列の形式が正しくない例外を処理する
            catch (FormatException)
            {
                resultDisplay.Text = "入力形式が正しくない";
                textDisplay.Clear();
            }
            EqualsClicked = true;
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
            else if ("0".Contains(lastChar) && !currentText.Contains(".") && currentText.Contains("÷")
                || ")".Contains(lastChar))
            {
                return;
            }

            if (!EqualsClicked)
            {
                // 等号がクリックしなかった場合、数字を入力する
                textDisplay.Text += num.Text;
            }
            else
            {
                // 等号がクリックした場合、テキストボックスの現在のデータが削除されて、新しい演算式を始める
                textDisplay.Clear();
                textDisplay.Text += num.Text;
                EqualsClicked = false;
            }
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
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1) + Operator;
            }
            // テキストボックスが空の場合、演算子を入力出来ない
            else if (currentText.Equals(""))
            {
                return;
            }

            if (!EqualsClicked)
            {
                // 等号がクリックしなかった場合、演算子を追加する
                textDisplay.Text += Operator;
            }
            else
            {
                // 等号がクリックした場合、前の演算式の結果を取得して、演算子を追加する
                textDisplay.Text = Result.ToString();
                textDisplay.Text += Operator;
                EqualsClicked = false;
            }
        }

        /// <summary>
        /// テキストボックスの内容が変更されたときに呼び出されるイベントハンドラー。
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void textDisplay_TextChanged(object sender, EventArgs e)
        {
            const int MaxNumberLength = 48;
            string currentText = textDisplay.Text;

            // 数字の長さが最大許容長を超えているかをチェックする
            if (currentText.Length > MaxNumberLength)
            {
                // 最大許容長を超える部分を切り取り、テキストボックスのテキストを表示する
                textDisplay.Text = currentText.Substring(0, MaxNumberLength);
            }

            // テキストボックスのクライアント領域の幅を取得
            int textWidth = TextRenderer.MeasureText(currentText, textDisplay.Font).Width;

            // フォントサイズが１７以上、テキストはテキストボックスの幅を超える場合、フォントサイズを小さくされる
            while (textWidth > textDisplay.ClientSize.Width && textDisplay.Font.Size > 17)
            {
                textDisplay.Font = new Font(textDisplay.Font.FontFamily, textDisplay.Font.Size - 0.5f, textDisplay.Font.Style);

                // 新しいフォントサイズでテキストの幅を再計算
                textWidth = TextRenderer.MeasureText(currentText, textDisplay.Font).Width;
            }
            if (textDisplay.Font.Size == 17)
            {
                // フォントサイズは１７が等しい場合にのみテキストが改行される
                textDisplay.WordWrap = true;
            }
            if (textWidth <= textDisplay.ClientSize.Width)
            {
                // テキストはテキストボックスの幅を超えない場合、フォントサイズを最初のサイズを戻られる
                float textSize = textDisplay.Font.Size + 0.5f;
                textDisplay.Font = new Font(textDisplay.Font.FontFamily, textSize > OriginalFontSize ? OriginalFontSize : textSize, textDisplay.Font.Style);
            }
        }

        /// <summary>
        /// テキストボックスのキャレットを削除するために
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベント引数</param>
        private void textDisplay_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}

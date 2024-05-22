using System;
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

        /// <summary>
        /// 数字ボタンがクリックされたときに呼び出される
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータを含む EventArgs</param>
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (textDisplay.Text == "0")
            {
                textDisplay.Clear();
            }
            textDisplay.Text += num.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button opr = (Button)sender;
            string currentText = textDisplay.Text;
            string lastChar = currentText.Length > 0 ? currentText.Last().ToString() : " ";
            if ("+-x÷.".Contains(lastChar))
            {
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1) + opr.Text;
            }
            else if (currentText.Equals("") && opr.Text.Equals("."))
            {
                textDisplay.Text = $"0{opr.Text}";
            }
            else if (currentText.Equals("") && opr.Text.Equals("x"))
            {
                textDisplay.Clear();
            }
            else if (currentText.Equals("") && opr.Text.Equals("÷"))
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

            if ("+-x÷.".Contains(lastChar))
            {
                textDisplay.Text = currentText.Substring(0, currentText.Length - 1);
            }

            string equation = textDisplay.Text;
            equation = equation.Replace("/", "÷").Replace("*", "x");
            var result = new DataTable().Compute(equation.Replace("÷", "/").Replace("x", "*"), null);
            if (equation.Contains("÷0"))
            {
                resultDisplay.Text = "Error";
                textDisplay.Clear();
            }
            else
            {
                resultDisplay.Text = "=" + result.ToString();
                textDisplay.Text = result.ToString();
            }
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
            string currentValue = textDisplay.Text;

            if (currentValue.StartsWith("-"))
            {
                textDisplay.Text = currentValue.Substring(1);
            }
            else
            {
                textDisplay.Text = "-" + currentValue;
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
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            // textDisplay の現在のテキストを取得する
            string currentValue = textDisplay.Text;

            // 最後の演算子の位置を検索する
            int lastOperatorIndex = Math.Max(currentValue.LastIndexOf("+"),
                Math.Max(currentValue.LastIndexOf("-"),
                Math.Max(currentValue.LastIndexOf("x"),
                currentValue.LastIndexOf("÷"))));

            // 演算子が見つからない場合、inputValue の値をパーセントに変換する
            if (lastOperatorIndex == -1)
            {
                if (float.TryParse(currentValue, out float inputValue))
                {
                    float percentValue = inputValue / 100;
                    textDisplay.Text = percentValue.ToString();
                }
            }
            else
            {
                // 演算子が見つける場合、演算子の後の数値を抽出すｒ
                string lastNumber = currentValue.Substring(lastOperatorIndex + 1);
                if (float.TryParse(lastNumber, out float lastValue))
                {
                    float percentValue = lastValue / 100;
                    // 演算子の前の部分とパーセントの値を結合して textDisplay を更新する
                    textDisplay.Text = currentValue.Substring(0, lastOperatorIndex + 1) + percentValue.ToString();
                }
            }
        }
    }
}

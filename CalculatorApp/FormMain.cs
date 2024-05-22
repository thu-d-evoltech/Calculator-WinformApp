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
            if (float.TryParse(textDisplay.Text, out float inputValue))
            {
                float percent = inputValue / 100;
                textDisplay.Text = percent.ToString();
            }
            else
            {
                MessageBox.Show("数字を入力してください。");
            }
        }
    }
}

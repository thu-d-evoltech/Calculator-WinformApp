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

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button opr = (Button)sender;
            textDisplay.Text += opr.Text;
        }
        
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string equation = textDisplay.Text;
            var result = new DataTable().Compute(equation, null);
            resultDisplay.Text = "=" + result.ToString();
            textDisplay.Text = result.ToString();

        }
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

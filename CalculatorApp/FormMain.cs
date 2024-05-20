using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text == "0")
            {
                textDisplay.Clear();
            }
            Button button = (Button)sender;
            textDisplay.Text += button.Text;
        }


        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string equation = textDisplay.Text;
            var result = new DataTable().Compute(equation, null);
            resultDisplay.Text = "=" + result.ToString();
            textDisplay.Text = result.ToString();
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

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            float negateValue = -float.Parse(textDisplay.Text);
            textDisplay.Text = negateValue.ToString();
        }

        /// <summary>
        /// ボタンCがクリックされたときの処理で、全てデータを消す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            resultDisplay.Text = "0";
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

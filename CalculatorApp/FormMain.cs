using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private DataTable Calc;

        /// <summary>
        /// 
        /// </summary>
        public Calculator()
        {
            Calc = new DataTable();
            InitializeComponent();
        }
        float num1, num2;
        int oprClickCount = 1;
        bool isOprClick = false;
        string opr;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!textDisplay.Text.Contains("."))
            {
                if (textDisplay.Text.Equals("0") && !button.Text.Equals("."))
                {
                    textDisplay.Text = button.Text;
                }
                else
                {
                    textDisplay.Text += button.Text;

                }
            }
            else if (!button.Text.Equals("."))
            {
                textDisplay.Text += button.Text;
            }
        }

        private bool isOperator(Button button)
        {
            string buttonText = button.Text;
            if(buttonText.Equals("+") || buttonText.Equals("-")  || 
                buttonText.Equals("x")  || buttonText.Equals("÷"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {

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

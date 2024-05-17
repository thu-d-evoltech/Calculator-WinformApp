using System;
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
        float data, result;
        String calculation;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text += num.Text;
            }
            else
            {
                textDisplay.Text += num.Text;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            if (data != 0)
            {
                buttonEquals.PerformClick();
            }
            Button cal = (Button)sender;
            calculation = cal.Text;
            data = float.Parse(textDisplay.Text);
            resultDisplay.Text = data.ToString() + calculation;
            textDisplay.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (calculation)
            {
                case "+":
                    result = data + float.Parse(textDisplay.Text);
                    resultDisplay.Text = data.ToString() + calculation + float.Parse(textDisplay.Text) + " =";
                    textDisplay.Text = result.ToString();
                    break;
                case "-":
                    result = data - float.Parse(textDisplay.Text);
                    resultDisplay.Text = data.ToString() + calculation + float.Parse(textDisplay.Text) + "=";
                    textDisplay.Text = result.ToString();
                    break;
                case "x":
                    result = data * float.Parse(textDisplay.Text);
                    resultDisplay.Text = data.ToString() + calculation + float.Parse(textDisplay.Text) + "=";
                    textDisplay.Text = result.ToString();
                    break;
                case "÷":
                    result = data / float.Parse(textDisplay.Text);
                    resultDisplay.Text = data.ToString() + calculation + float.Parse(textDisplay.Text) + "=";
                    textDisplay.Text = result.ToString();
                    break;
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
            data = 0;
            result = 0;
            resultDisplay.Clear();
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

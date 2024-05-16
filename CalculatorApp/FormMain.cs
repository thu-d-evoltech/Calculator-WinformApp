using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        float data, result;
        String calculation;

        //数を入力する機能
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text += num.Text;
            }
            else
                textDisplay.Text += num.Text;
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            calculation = num.Text;
            data = float.Parse(textDisplay.Text);
            textDisplay.Clear();
            resultDisplay.Text = data.ToString() + calculation;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (calculation)
            {
                case "+":
                    result = data + float.Parse(textDisplay.Text);
                    resultDisplay.Text = "=" + result.ToString();
                    break;
                case "-":
                    result = data - float.Parse(textDisplay.Text);
                    resultDisplay.Text = "=" + result.ToString();
                    break;
                case "x":
                    result = data * float.Parse(textDisplay.Text);
                    resultDisplay.Text = "=" + result.ToString();
                    break;
                case "÷":
                    result = data / float.Parse(textDisplay.Text);
                    resultDisplay.Text = "=" + result.ToString();
                    break;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
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
    }
}

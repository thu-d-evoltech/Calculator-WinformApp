using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class 電卓 : Form
    {
        public 電卓()
        {
            InitializeComponent();
        }
        float data1, data2;
        String Calculation;
        //数を入力する機能
        private void Button_Click(object sender, EventArgs e)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Calculation = "Add";
            data1 = float.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (Calculation == "Add")
            {
                data2 = data1 + float.Parse(textDisplay.Text);
                resultDisplay.Text = data2.ToString();
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            resultDisplay.Clear();
        }
    }
}

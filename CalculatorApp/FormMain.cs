using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class 電卓 : Form
    {
        public 電卓()
        {
            InitializeComponent();
        }

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
    }
}

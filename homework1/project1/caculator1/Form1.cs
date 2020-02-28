using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    result.Text = "请选择运算符";//未选择运算符处理
                }
                else if (number1.Text == "" || number2.Text == "")
                {
                    result.Text = "请输入完整的两个字符";//空字符处理
                }
                else
                {
                    double a = double.Parse(number1.Text);
                    double b = double.Parse(number2.Text);
                    switch (comboBox1.Text)
                    {
                        case "+":
                            result.Text = $"{ a + b}";
                            break;
                        case "-":
                            result.Text = $"{ a - b}";
                            break;
                        case "*":
                            result.Text = $"{ a * b}";
                            break;
                        case "/":
                            if (b == 0)
                                result.Text = "除数不可为零";
                            else
                                result.Text = $"{ a / b}";
                            break;
                    }
                }
            }
            catch
            {
                result.Text="输入字符无法进行计算";//非数字输入处理
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

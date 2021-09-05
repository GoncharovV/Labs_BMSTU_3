using System;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {

        private readonly Calculator calculator;
        public Form1()
        {
            InitializeComponent();

            calculator = new Calculator();

            calculator.CalculatorValueChanged += DisplayValue;
            calculator.CalculatorErrorOccrued += DisplayError;
        }

        private void DisplayValue(string value)
        {
            textBox1.Text = value;
        }

        private void DisplayError(string value)
        {
            MessageBox.Show(value, "Ошибка");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calculator.ProcessNumber(9);
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            calculator.ProcessOperation(Calculator.Operations.Plus);
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            calculator.ProcessOperation(Calculator.Operations.Subtract);
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            calculator.ProcessOperation(Calculator.Operations.Multiply);
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            calculator.ProcessOperation(Calculator.Operations.Divide);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            calculator.Backspace();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            calculator.Calc();
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            calculator.AddDot();
        }
        private void button_sqrt_Click(object sender, EventArgs e)
        {
            calculator.Sqrt();
        }

        private void button_save_to_memory_Click(object sender, EventArgs e)
        {
            calculator.AddToMemory();
        }

        private void button_get_from_memory_Click(object sender, EventArgs e)
        {
            calculator.GetFromMemory();
        }

        private void button_clear_memory_Click(object sender, EventArgs e)
        {
            calculator.ClearMemory();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}

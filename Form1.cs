
using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCompute.Click += btnCompute_Click;

            cmbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperator.SelectedIndex = 0;
        }

        private void btnCompute_Click(object? sender, EventArgs e)
        {
            float num1, num2;

            if (!float.TryParse(txtNum1.Text, out num1) ||
                !float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            float result;

            switch (cmbOperator.Text)
            {
                case "+":
                    result = BasicComputation.Addition(num1, num2);
                    break;

                case "-":
                    result = BasicComputation.Subtraction(num1, num2);
                    break;

                case "*":
                    result = BasicComputation.Multiplication(num1, num2);
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        return;
                    }

                    result = BasicComputation.Division(num1, num2);
                    break;

                default:
                    MessageBox.Show("Select an operator.");
                    return;
            }

            lblResult.Text = result.ToString();
        }
    }
}

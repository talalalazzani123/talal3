using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الثالثة
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string operation1 = textOperation1.Text;
            string operation2 = textOperation2.Text;

            if (double.TryParse(txtNumber1.Text, out number1) &&
                double.TryParse(txtNumber2.Text, out number2) &&
                double.TryParse(txtNumber3.Text, out number3))
            {
                double intermediateResult, finalResult;

                // تطبيق أولوية العمليات: الضرب والقسمة قبل الجمع والطرح
                if (operation1 == "*" || operation1 == "/")
                {
                    intermediateResult = PerformOperation(number1, number2, operation1);
                    finalResult = PerformOperation(intermediateResult, number3, operation2);
                }
                else if (operation2 == "*" || operation2 == "/")
                {
                    intermediateResult = PerformOperation(number2, number3, operation2);
                    finalResult = PerformOperation(number1, intermediateResult, operation1);
                }
                else
                {
                    // إذا كانت جميع العمليات + أو -
                    intermediateResult = PerformOperation(number1, number2, operation1);
                    finalResult = PerformOperation(intermediateResult, number3, operation2);
                }

                if (double.IsNaN(finalResult))
                {
                    MessageBox.Show("خطأ في العمليات الحسابية.");
                }
                else
                {
                    textResult.Text = finalResult.ToString();
                }
            }
            else
            {
                MessageBox.Show("يرجى إدخال أرقام صحيحة.");
            }
        }

        // دالة تنفيذ العملية الحسابية
        private double PerformOperation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : double.NaN;
                default:
                    return double.NaN;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace المحاضرة_الثالثة
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }
                label1.Text = "المجموع: " + sum;
            }
            else
            {
                MessageBox.Show("يرجى إدخال عدد صحيح.");
            }
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                label2.Text = "المضروب: " + factorial;
            }
            else
            {
                MessageBox.Show("يرجى إدخال عدد صحيح.");
            }
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                label3.Text = "الجذر: " + Math.Sqrt(number).ToString("F2");
            }
            else
            {
                MessageBox.Show("يرجى إدخال عدد.");
            }
        }
    }
}

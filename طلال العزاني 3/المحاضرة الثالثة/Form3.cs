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
    public partial class Form3 : Form
    {
        double x, y, z;

        public Form3()
        {
            InitializeComponent();

            // إضافة العمليات إلى ListBox
            listBox1.Items.Add("+");
            listBox1.Items.Add("-");
            listBox1.Items.Add("*");
            listBox1.Items.Add("/");
            listBox1.SelectedIndex = 0; // تعيين العنصر الافتراضي
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtr.ReadOnly = true;
            listBox1.SelectionMode = SelectionMode.One; // اختيار عنصر واحد فقط
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformCalculation();
        }

        private void PerformCalculation()
        {
            // التحقق من صحة المدخلات
            try
            {
                x = Convert.ToDouble(txtn1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير", "العدد الأول غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtn1.Text = "";
                txtn1.Focus();
                return;
            }

            try
            {
                y = Convert.ToDouble(txtn2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير", "العدد الثاني غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtn2.Text = "";
                txtn2.Focus();
                return;
            }

            bool f = true;

            // تنفيذ العملية بناءً على الاختيار في ListBox
            switch (listBox1.SelectedIndex)
            {
                default: break;
                case 0: z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                    if (y != 0)
                    {
                        z = x / y;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر");
                        f = false;
                        txtr.Text = null;
                        break;
                    }
            }

            if (f)
            {
                txtr.Text = z.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn2.Text = txtr.Text = null;
        }
    }
}

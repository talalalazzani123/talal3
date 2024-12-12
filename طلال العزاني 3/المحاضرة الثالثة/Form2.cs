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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void traingforsender(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                
                if (clickedButton == btnyellow)
                    button1.BackColor = Color.Yellow;
                else if (clickedButton == btnred)
                    button1.BackColor = Color.Red;
                else if (clickedButton == btngreen)
                    button1.BackColor = Color.Green;
            }

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // التحقق من اسم الجهاز الذي تم الضغط عليه
                if (clickedLabel == device2)
                    button1.Text = device2.Text;
                else if (clickedLabel == device1)
                    button1.Text = device1.Text; 
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

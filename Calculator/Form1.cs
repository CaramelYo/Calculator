using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            divisor_textbox.Text = "";
            dividend_textbox.Text = "";
            answer_label.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int divisor = 0, dividend = 0;

            try
            {
                divisor = int.Parse(divisor_textbox.Text);
                dividend = int.Parse(dividend_textbox.Text);
            }
            catch
            {
                answer_label.Text = "輸入的並非數值";
                return;
            }

            answer_label.Text = "答案是 : " + (dividend / divisor).ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}

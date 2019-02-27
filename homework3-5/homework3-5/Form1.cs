using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);
            double result = num1 * num2;
            this.textBox3.Text = "结果是:"+result;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

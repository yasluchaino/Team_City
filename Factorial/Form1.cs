using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        Fact f;
        public Form1()
        {
            InitializeComponent();
            f = new Fact();
            textBox2.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            var res = f.Factorial(int.Parse(textBox2.Text));
            label2.Text = res.ToString();
        }
    }
}

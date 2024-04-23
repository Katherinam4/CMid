using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FractionArray obj1 = new FractionArray();
            float[] array = { 26.7f, 50.1f, 24.3f, 100.5f, 25.4f };
            float result = obj1.Gamotana(array);
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Calculator calculator2 = new Calculator();
            float numFloat = float.Parse(textBox1.Text);
            float res = calculator2.Axarisxeba(numFloat);
            label2.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox2.Text);
            Calculator calculator = new Calculator();
            int reasult = calculator.Axarisxeba(num);
            label3.Text = reasult.ToString();
        }
    }
}

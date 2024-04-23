using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int value = int.Parse(textBox1.Text);

            Jeradi obj = new Jeradi();
            obj.Tviseba = value;
            label1.Text = obj.Tviseba.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gv1 = int.Parse(textBox2.Text);
            int gv2 = int.Parse(textBox3.Text);
            Figure obj1 = new Figure(gv1,gv2);

            label2.Text = "Perimetri: " + obj1.MtavariPerimetri();

            float gv1wiladi = float.Parse(textBox4.Text);
            float gv2wiladi = float.Parse(textBox5.Text);
            Figure obj2 = new Figure(gv1wiladi, gv2wiladi);
            label3.Text = "Fartobi: " + obj2.MtavariFartobi().ToString();

        }
    }
}

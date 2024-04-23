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

namespace Midterm_Var4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = { 8, 12, 5, 20, 16 };
            Class1 obj = new Class1();
            label1.Text = obj.Jeradebi(data).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gvari;
            string saxeli;
            int asaki;

            gvari = textBox1.Text;
            saxeli = textBox2.Text;
            asaki = int.Parse(textBox3.Text);



            int palatis_nomeri;
            string saavadmyofos_dasaxeleba;
            int gadasaxdeli_tanxa;

            palatis_nomeri = int.Parse(textBox4.Text);
            saavadmyofos_dasaxeleba = textBox5.Text;
            gadasaxdeli_tanxa = int.Parse(textBox6.Text);

            Avadmyofi obj = new Avadmyofi(palatis_nomeri, saavadmyofos_dasaxeleba, gadasaxdeli_tanxa, gvari, saxeli, asaki);

            obj.Gamotana(label8);
        }

    }
}

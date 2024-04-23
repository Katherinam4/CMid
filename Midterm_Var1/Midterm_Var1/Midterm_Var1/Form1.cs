using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Var1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Martkutxedi Mart1 = new Martkutxedi();

            Mart1.gverdi1 = int.Parse(textBox1.Text);
            Mart1.gverdi2 = int.Parse(textBox2.Text);
            Mart1.Fartobi(label4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gvari;
            string saxeli;
            int asaki;

            gvari = textBox3.Text;
            saxeli = textBox4.Text;
            asaki = int.Parse(textBox5.Text);

            

            int palatis_nomeri;
            string saavadmyofos_dasaxeleba;
            int gadasaxdeli_tanxa;

            palatis_nomeri = int.Parse(textBox6.Text);
            saavadmyofos_dasaxeleba = textBox7.Text;
            gadasaxdeli_tanxa = int.Parse(textBox8.Text);

            Avadmyofi obj = new Avadmyofi(palatis_nomeri, saavadmyofos_dasaxeleba, gadasaxdeli_tanxa, gvari, saxeli, asaki);

            obj.Gamotana(label10);
        }
    }
}

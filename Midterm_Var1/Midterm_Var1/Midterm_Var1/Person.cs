using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Var1
{
    class Person
    {
        protected string gvari;
        protected string saxeli;
        protected int asaki;

        public Person(string gvari, string saxeli, int asaki)
        {
            this.gvari = gvari;
            this.saxeli = saxeli;
            this.asaki = asaki;
        }
    }

    class Avadmyofi : Person
    {
        public int palatis_nomeri;
        public string saavadmyofos_dasaxeleba;
        public int gadasaxdeli_tanxa;

        public Avadmyofi(int palatis_nomeri, string saavadmyofos_dasaxeleba, int gadasaxdeli_tanxa, string gvari, string saxeli, int asaki) : base(gvari, saxeli, asaki)
        {
            this.palatis_nomeri = palatis_nomeri;
            this.saavadmyofos_dasaxeleba = saavadmyofos_dasaxeleba;
            this.gadasaxdeli_tanxa = gadasaxdeli_tanxa;
        }

        public void Gamotana(Label label4)
        {
            label4.Text = "gvari: " + gvari +
                         "\nsaxeli: " + saxeli +
                         "\nasaki: " + asaki +
                         "\npalatis_nomeri: " + palatis_nomeri +
                         "\nsaavadmyofos_dasaxeleba: " + saavadmyofos_dasaxeleba +
                         "\ngadasaxdeli_tanxa: " + gadasaxdeli_tanxa.ToString();
        }
    }

}

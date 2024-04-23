using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1d
{
    internal class Figure
    {
        int mteliGv1;
        int mteliGv2;
        float wiladiGv1;
        float wiladiGv2;
        int perimetri;
        float fartobi;

        public Figure(int gv1, int gv2)
        {
            mteliGv1 = gv1;
            mteliGv2 = gv2;
            perimetri = 2 * (gv1 + gv2);
        }

        public Figure(float gv1, float gv2)
        {
            wiladiGv1 = gv1;
            wiladiGv2 = gv2;
            fartobi = gv1 * gv2;
        }

        public int MtavariPerimetri() 
        { 
            return perimetri;
        }
        public float MtavariFartobi() 
        { 
            return fartobi;
        }

    }
}

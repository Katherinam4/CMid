using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class FractionArray
    {
        float[] array;

        public float Gamotana(float[] array)
        { 
            this.array = array;
            float sum = 0;
            foreach (float value in this.array)
            {
                if (value > 25.5f)
                    sum += value;
            }
            return sum;

        }
    }
}

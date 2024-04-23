using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Var4
{
    class Class1
    {
        int[] arr;

        public int Jeradebi(int[] arr)
        {
            this.arr = arr;
            int sum = 0;
            foreach (int item in this.arr)
            {
                if (item % 4 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}

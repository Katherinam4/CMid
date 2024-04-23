using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1d
{
    internal class Jeradi
    {
        private int number;

        public int Tviseba
        {
            get { return number; }
            set
            {
                if (value % 6 == 0 && value < 34)
                {
                    number = value;
                }

            }
        }
    }
}

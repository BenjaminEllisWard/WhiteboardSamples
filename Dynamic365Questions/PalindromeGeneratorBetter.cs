using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class PalindromeGeneratorBetter
    {
        public bool Check(int number, int reverse)
        {
            return number == reverse ? true : false;
        }

        public int Reverse(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                reverse = (reverse * 10) + number % 10;
                number /= 10;
            }

            return reverse;
        }

        public int Output(int number)
        {
            while (Check(number, Reverse(number)) == false)
            {
                number += Reverse(number);
            }

            return number;
        }
    }
}

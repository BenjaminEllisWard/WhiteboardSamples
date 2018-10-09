using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class DigitalRoot
    {
        // Given an integer number, add all its digits, and then add the sums digits, repeat until you have a single digit number
        public int GetDigitalRoot(int number)
        {
            int digit = 0;
            while (number % 10 != 0)
            {
                digit += number % 10;
                number /= 10;
            }

            if (digit / 10 != 0)
            {
                digit = GetDigitalRoot(digit);
            }

            return digit;
        }

        public void Run(int number)
        {
            Console.WriteLine(GetDigitalRoot(number).ToString());
        }
    }
}

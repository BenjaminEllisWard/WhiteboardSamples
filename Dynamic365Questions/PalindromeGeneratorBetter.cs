using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class PalindromeGeneratorBetter
    {
        // Generate a palindrome by adding a number to its reversed self. If that number is not a palindrome, repeat the operation until one
        // is acheived. Return false if a palindrome less than 1,000,000 cannot be generated.

        public bool Check(int number, int reverse)
        {
            return number == reverse ? true : false;
        }

        public int Reverse(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                // multiply current value of reverse by 10 and add next digit of number to reverse's one's place
                reverse = (reverse * 10) + number % 10;

                // remove one's place from number before repeating while block
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

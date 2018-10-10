using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class PalindromeGenerator
    {
        // generate a palindrome by adding a number to its reversed self. If that number is not a palindrome, repeat the operation until one
        // is acheived. Return false if a palindrome less than 1,000,000 cannot be generated.

        public bool Check(int number)
        {
            bool isPal = true;
            List<int> Pal = new List<int>();

            while (number > 0)
            {
                // add last digit of number to list, then remove last digit from number
                Pal.Add(number % 10);
                number /= 10;
            }

            for (int i = 0; i <= Pal.Count / 2; ++i)
            {
                // check first digit against last, converge iterations toward the middle of list
                if (Pal[i] != Pal[Pal.Count - 1 - i])
                {
                    isPal = false;
                    break;
                }
            }

            return isPal;
        }

        public int Generate(int number)
        {
            if (Check(number) == false)
            {
                int pal = number;

                // number's order of magnitude
                int power = Convert.ToInt32(Math.Floor(Math.Log10(number)));


                while (number > 0)
                {
                    // last digit is raised to a power and added to pal
                    pal += (number % 10) * Convert.ToInt32(Math.Pow(10, power));

                    // remove last digit from number
                    number /= 10;

                    // next iteration of loop will raise next digit to one power less the current iteration
                    power--;
                }

                // Recurses if pal is under 1,000,000 and is not a palindrome
                while (Check(pal) == false && pal < 1000000)
                {
                    pal = Generate(pal);
                }
                return pal;
            }

            // return number if it is already a palindrome
            return number;
        }

        public string Output(int number)
        {
            int pal = 0;

            pal += Generate(number);

            return pal >= 1000000 ? "No palindrome under 1,000,000" : pal.ToString();
        }
    }
}

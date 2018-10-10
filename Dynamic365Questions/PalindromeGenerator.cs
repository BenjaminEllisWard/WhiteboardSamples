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

            while (number / 10 != 0 || number > 0)
            {
                Pal.Add(number % 10);
                number /= 10;
            }

            for (int i = 0; i <= Pal.Count / 2; ++i)
            {
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
                int x = 10;
                int power = Convert.ToInt32(Math.Floor(Math.Log10(number)));


                while (number / 10 > 0 || number % 10 != 0)
                {
                    pal += (number % 10) * Convert.ToInt32(Math.Pow(10, power));
                    x *= 10;
                    power--;
                    number /= 10;
                }
                while (Check(pal) == false && pal < 1000000)
                {
                    pal = Generate(pal);
                }
                return pal;
            }
            return number;
        }

        public string output(int number)
        {
            string message = null;

            message += Generate(number).ToString();

            return message == "1000000" ? "No palindrone under 1,000,000" : message;
        }
    }
}

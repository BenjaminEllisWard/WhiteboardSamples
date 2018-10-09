using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class StringChecker
    {
        // Write a function that can determine if two string are one edit (insert, replace, or remove char) or less within equivalence

        public bool Check(string first, string second)
        {
            if (first == second)
            {
                Console.WriteLine("Strings are equivalent.");
                return true;
            }
            else if (first.Length == second.Length)
            {
                int count = 0;
                for (int i = 0; i < first.Length - 1; ++i)
                {
                    if (first.ElementAt(i) != second.ElementAt(i))
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    return false;
                }
                Console.WriteLine("Strings are different by one replace.");
                return true;
            }
            else if (first.Length + 1 == second.Length)
            {
                for (int i = 0; i < second.Length - 1; ++i)
                {
                    if (first.ElementAt(i) != second.ElementAt(i))
                    {
                        for (int j = 1 + i; j < second.Length - 1; j++)
                        {
                            if (first.ElementAt(j) != second.ElementAt(j + 1))
                            {
                                return false;
                            }
                        }
                    }
                }
                Console.WriteLine("Strings are different by one insert.");
                return true;
            }
            else if (first.Length == second.Length + 1)
            {
                for (int i = 0; i < first.Length - 1; ++i)
                {
                    if (first.ElementAt(i) != second.ElementAt(i))
                    {
                        for (int j = 1 + i; j < first.Length - 1; j++)
                        {
                            if (first.ElementAt(j + 1) != second.ElementAt(j))
                            {
                                return false;
                            }
                        }
                    }
                }
                Console.WriteLine("Strings are different by one remove.");
                return true;
            }
            else
            {
                Console.WriteLine("Strings cannot be made equal with a single edit.");
                return false;
            }
        }
    }
}

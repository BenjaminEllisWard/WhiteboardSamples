using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class StringCheckerBetter
    {
        public bool CheckString(string first, string second)
        {
            if (first.Equals(second)) { Console.WriteLine("The strings are equivalent."); return true; }

            else if (first.Length == second.Length) { return OneReplace(first, second); }

            else if (first.Length == second.Length - 1) { return OneInsert(first, second, "insert"); }

            else if (first.Length == second.Length + 1) { return OneInsert(second, first, "remove"); }

            else
            {
                Console.WriteLine("The strings cannot be made equivalent with one edit.");
                return false;
            }
        }

        public bool OneReplace(string first, string second)
        {
            for (int i = 0; i < first.Length; ++i)
            {
                if (first.ElementAt(i) != second.ElementAt(i))
                {
                    for (int j = i + 1; j < first.Length; ++j)
                    {
                        if (first.ElementAt(j) != second.ElementAt(j))
                        {
                            Console.WriteLine("The strings cannot be made equivalent with one edit.");
                            return false;
                        }
                    }
                }
            }
            Console.WriteLine("The strings are different by one replace.");
            return true;
        }

        public bool OneInsert(string first, string second, string insertOrRemove)
        {
            for (int i = 0; i < first.Length; ++i)
            {
                if (first.ElementAt(i) != second.ElementAt(i))
                {
                    for (int j = 1 + i; j < first.Length; j++)
                    {
                        if (first.ElementAt(j) != second.ElementAt(j + 1))
                        {
                            Console.WriteLine("The strings cannot be made equivalent with one edit.");
                            return false;
                        }
                    }
                }
            }
            Console.WriteLine($"The first string can be made equivalent to the second string with one {insertOrRemove}.");
            return true;
        }
    }
}

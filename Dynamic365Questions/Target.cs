using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class Target
    {
        // Given an array of integers, return two integers such that they add up to a specific target. Assume
        // that each input array would have exactly one solution, and you may not use the same element twice.

        public void Run(int[] integers, int target)
        {
            int[] solution = FindSoln(integers, target);
            Console.WriteLine(string.Join(", ", solution));
        }

        public int[] FindSoln(int[] integers, int target)
        {
            int[] solution = new int[2];

            foreach (int n in integers)
            {
                // Condition ensures that two distinct members satisfy solution.
                if (integers.Contains(target - n) && Array.IndexOf(integers, target - n) != Array.IndexOf(integers, n))
                {
                    solution[0] = Math.Min(n, target - n);
                    solution[1] = Math.Max(n, target - n);
                    return solution;
                }
            }

            throw new Exception("Target value is not equal to the sum of any two values of input array.");
        }
    }
}

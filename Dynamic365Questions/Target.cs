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
                if (n < target)
                {
                    if (integers.Contains(target - n))
                    {
                        solution[0] = n;
                        solution[1] = target - n;
                        solution = AscSort(solution);
                        return solution;
                    }
                }
            }

            throw new Exception("Target value is not equal to the sum of any two values of input array.");
        }

        public int[] AscSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; ++i)
            {
                for (int j = i + 1; j < a.Length; ++j)
                {
                    if (a[i] > a[j])
                    {
                        int x = a[i];

                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }

            return a;
        }
    }
}

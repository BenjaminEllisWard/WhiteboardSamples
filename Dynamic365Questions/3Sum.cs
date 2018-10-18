using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    // Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0?
    // Find all unique triplets in the array which give the sum of zero.
    public class _3Sum
    {
        public List<int[]> FindTrip(int[] numbers)
        {
            List<int[]> solutions = new List<int[]>();

            for (int h = 0; h < numbers.Length - 2; h++)
            {
                for (int i = h + 1; i < numbers.Length - 1; ++i)
                {
                    for (int j = i + 1; j < numbers.Length; ++j)
                    {
                        if (numbers[h] + numbers[i] + numbers[j] == 0)
                        {
                            solutions.Add(new int[] { numbers[h], numbers[i], numbers[j] });
                        }
                    }
                }
            }

            if (solutions == null)
            {
                throw new Exception("No three numbers in the input array sum to three.");
            }

            return solutions;
        }
    }
}

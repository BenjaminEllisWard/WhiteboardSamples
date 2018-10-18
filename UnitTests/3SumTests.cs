using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic365Questions;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class _3SumTests
    {
        [TestMethod]
        public void FindTrip_WithValidSoln()
        {
            // Arrange
            int[] numbers = new int[] { -2, -1, 0, 1, 2, 3 };
            List<int[]> expected = new List<int[]>
            {
                new int[] { -2, -1, 3 },
                new int[] { -2, 0, 2 },
                new int[] { -1, 0, 1 }
            };
            _3Sum test = new _3Sum();

            // Act
            List<int[]> actual = test.FindTrip(numbers);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindTrip_WithNoValidSoln()
        {
            // Arrange
            int[] numbers = new int[] { -2, -1, 0, 6 };
            _3Sum test = new _3Sum();

            // Act
            try
            {
                List<int[]> actual = test.FindTrip(numbers);
            }
            catch (Exception e)
            {
                // Assert
                StringAssert.Contains(e.Message, "No three numbers in the input array sum to three.");
                return;
            }
        }
    }
}

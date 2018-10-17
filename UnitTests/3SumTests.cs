using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic365Questions;

namespace UnitTests
{
    [TestClass]
    public class _3SumTests
    {
        [TestMethod]
        public void FindTrip_WithValidSoln()
        {
            // Arrange
            int[] numbers = new int[] { -2, -1, 0, 1 };
            int[] expected = new int[] { -1, 0, 1 };
            _3Sum test = new _3Sum();

            // Act
            int[] actual = test.FindTrip(numbers);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindTrip_WithNoValidSoln()
        {
            // Arrange
            int[] numbers = new int[] { -2, -1, 0, 3 };
            _3Sum test = new _3Sum();

            // Act
            try
            {
                int[] actual = test.FindTrip(numbers);
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

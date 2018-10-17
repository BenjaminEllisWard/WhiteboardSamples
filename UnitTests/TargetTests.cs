using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic365Questions;

namespace UnitTests
{
    [TestClass]
    public class TargetTests
    {
        [TestMethod]
        public void FindSoln_WithValidSoln()
        {
            // Arrange
            int[] numbers = new int[] { 1, 2, 4 };
            int[] expected = new int[] { 2, 4 };
            int target = 6;
            Target test = new Target();

            // Act
            int[] actual = test.FindSoln(numbers, target);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindSoln_WithNoSoln()
        {
            // Arrange
            int[] numbers = new int[] { 1, 2, 4 };
            int target = 7;
            Target test = new Target();

            try
            {
                // Act
                int[] actual = test.FindSoln(numbers, target);
            }
            catch (Exception e)
            {
                // Assert
                StringAssert.Contains(e.Message, "Target value is not equal to the sum of any two values of input array.");
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}

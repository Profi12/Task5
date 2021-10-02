using NUnit.Framework;
using System;
using Task5_Library;

namespace Task5_Tests
{
    public class Task5_Tests
    {
        private static object[] ValidTestDataForMin =
        {
            new object[] { new int[,] { { 504, 37 }, { 94, 282 }, { 1, 102 } }, 1 },
            new object[] { new int[,] { { 225, 33, 104 }, { 298, 812, 7 } }, 7 },
            new object[] { new int[,] { { 537, 32 }, { 55, 91 } }, 32 },
            new object[] { new int[,] { { 456, 30 }, { 459, 74 } }, 30 },
            new object[] { new int[,] { { 481 }, { 12 } }, 12 }
        };

        [TestCaseSource("ValidTestDataForMin")]
        public void Min_WhenFilledArrayPassed_ShouldGetMinimumElementOfArray(
              int[,] array, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.Min(array));
        }


        private static object[] InValidTestDataForMin =
        {
            new object[] { new int[,] { {  }, { } } },
            new object[] { null }
        };

        [TestCaseSource("InValidTestDataForMin")]
        public void Min_WhenIncorrectInput_ShouldThrowArgumentException(int[,] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.Min(array);
            });
        }

        private static object[] ValidTestDataForMax =
        {
            new object[] { new int[,] { { 504, 37 }, { 94, 282 }, { 1, 102 } }, 504 },
            new object[] { new int[,] { { 225, 33, 104 }, { 298, 812, 7 } }, 812 },
            new object[] { new int[,] { { 537, 32 }, { 55, 91 } }, 537 },
            new object[] { new int[,] { { 456, 30 }, { 459, 74 } }, 459 },
            new object[] { new int[,] { { 481 }, { 12 } },481 }
        };

        [TestCaseSource("ValidTestDataForMax")]
        public void Max_WhenFilledArrayPassed_ShouldGetMaximumElementOfArray(
            int[,] array, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.Max(array));
        }


        private static object[] InValidTestDataForMax =
        {
            new object[] { new int[,] { {  }, { } } },
            new object[] { null }
        };

        [TestCaseSource("InValidTestDataForMax")]
        public void Max_WhenIncorrectInput_ShouldThrowArgumentException(int[,] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.Max(array);
            });
        }
    }
}
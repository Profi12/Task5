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

        private static object[] ValidTestDataForMinIndex =
        {
            new object[] { new int[,] { { 504, 37 }, { 94, 282 }, { 1, 102 } }, 2,0 },
            new object[] { new int[,] { { 225, 33, 104 }, { 298, 812, 7 } }, 1,2 },
            new object[] { new int[,] { { 537, 32 }, { 55, 91 } }, 0,1 },
            new object[] { new int[,] { { 456, 30 }, { 459, 74 } }, 0,1 },
            new object[] { new int[,] { { 481 }, { 12 } }, 1,0 }
        };

        [TestCaseSource("ValidTestDataForMinIndex")]
        public void MinIndex_WhenFilledArrayPassed_ShouldGetMaximumElementOfArray(
            int[,] array, int expectedI, int expectedJ)
        {
            Assert.AreEqual((expectedI, expectedJ), TaskHelper.MinIndex(array));
        }


        private static object[] InValidTestDataForMinIndex =
        {
            new object[] { new int[,] { {  }, { } } },
            new object[] { null }
        };

        [TestCaseSource("InValidTestDataForMinIndex")]
        public void MinIndex_WhenIncorrectInput_ShouldThrowArgumentException(int[,] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.MinIndex(array);
            });
        }
        private static object[] ValidTestDataForMaxIndex =
       {
            new object[] { new int[,] { { 504, 37 }, { 94, 282 }, { 1, 102 } }, 0,0 },
            new object[] { new int[,] { { 225, 33, 104 }, { 298, 812, 7 } }, 1,1 },
            new object[] { new int[,] { { 537, 32 }, { 55, 91 } }, 0,0 },
            new object[] { new int[,] { { 456, 30 }, { 459, 74 } }, 1,0 },
            new object[] { new int[,] { { 481 }, { 12 } }, 0,0 }
        };

        [TestCaseSource("ValidTestDataForMaxIndex")]
        public void MaxIndex_WhenFilledArrayPassed_ShouldGetMaximumElementOfArray(
            int[,] array, int expectedI, int expectedJ)
        {
            Assert.AreEqual((expectedI, expectedJ), TaskHelper.MaxIndex(array));
        }


        private static object[] InValidTestDataForMaxIndex =
        {
            new object[] { new int[,] { {  }, { } } },
            new object[] { null }
        };

        [TestCaseSource("InValidTestDataForMaxIndex")]
        public void MaxIndex_WhenIncorrectInput_ShouldThrowArgumentException(int[,] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.MaxIndex(array);
            });
        }
        private static object[] ValidTestDataForGetNeighboursCounter =
        {
            new object[] { new int[,] { { 504, 37 }, { 94, 282 }, { 1, 102 } }, 2 },
            new object[] { new int[,] { { 225, 33, 104 }, { 298, 812, 7 } }, 2 },
            new object[] { new int[,] { { 537, 32 }, { 55, 91 } }, 2 },
            new object[] { new int[,] { { 456, 30 }, { 459, 74 } }, 1 },
            new object[] { new int[,] { { 481 }, { 12 } },1 }
        };

        [TestCaseSource("ValidTestDataForGetNeighboursCounter")]
        public void GetNeighboursCounter_WhenFilledArrayPassed_ShouldGetMaximumElementOfArray(
            int[,] array, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.GetNeighboursCounter(array));
        }

        private static object[] InValidTestDataForGetNeighboursCounter =
        {
            new object[] { new int[,] { {  }, { } } },
            new object[] { null }
        };

        [TestCaseSource("InValidTestDataForGetNeighboursCounter")]
        public void GetNeighboursCounter_WhenIncorrectInput_ShouldThrowArgumentException(int[,] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.GetNeighboursCounter(array);
            });
        }

        private static object[] ValidTestDataForTransponateMatrix =
        {
            new object[]
            {
                new int[,]
                {
                    { 1, 2 },
                    { 3, 4 },
                    { 5, 6 }
                },
                new int[,]
                {
                    { 1, 3 },
                    { 2, 4 },
                    { 5, 6 }
                }
            },
            new object[]
            {
                new int[,]
                {
                    { 1, 2, 3},
                    { 4, 5, 6 }
                },
                new int[,]
                {
                    { 1, 4, 3 },
                    { 2, 5, 6 }
                }
            },
            new object[]
            {
                new int[,]
                {
                    { 1, 2 },
                    { 3, 4 }
                },
                new int[,]
                {
                    { 1, 3 },
                    { 2, 4 }
                }
            },
            new object[]
            {
                new int[,]
                {
                    { 1, 2, 3},
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                new int[,]
                {
                    { 1, 4, 7 },
                    { 2, 5, 8 },
                    { 3, 6, 9 }
                }
            },
        };

        [TestCaseSource("ValidTestDataForTransponateMatrix")]
        public void TransponateMatrix_WhenFilledArrayPassed_ShouldGetMinimumElementOfArray(
              int[,] array, int[,] expected)
        {
            TaskHelper.TransponateMatrix(array);
            Assert.AreEqual(expected, array);
        }


        private static object[] InValidTestDataForTransponateMatrix =
        {
            new object[] { new int[,] { {  }, { } } },
            new object[] { null }
        };

        [TestCaseSource("InValidTestDataForTransponateMatrix")]
        public void TransponateMatrix_WhenIncorrectInput_ShouldThrowArgumentException(int[,] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.TransponateMatrix(array);
            });
        }
    }
}
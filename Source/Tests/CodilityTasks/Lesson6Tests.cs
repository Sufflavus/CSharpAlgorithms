using System;
using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson6Tests
    {
        [Theory]
        [InlineData(new[] { 1, 8, 4, 2, 4, 5 })]
        [InlineData(new[] { 1, -8, 4, 2, -4, 5 })]
        public void SelectionSort_CorrectResult(int[] array)
        {
            int[] result = Lesson6.SelectionSort(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.True(result[i+1] >= result[i]);
            }
        }

        [Theory]
        [InlineData(new[] { 1, 8, 4, 2, 4, 5 }, 8)]
        [InlineData(new[] { 1, 3, 2, 7, 9, 0 }, 9)]
        public void CountingSort_CorrectResult(int[] array, int k)
        {
            int[] result = Lesson6.CountingSort(array, k);

            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.True(result[i + 1] >= result[i]);
            }
        }

        [Theory]
        [InlineData(new[] { 1, 8, 4, 2, 4, 5 })]
        [InlineData(new[] { 1, 3, 2, 7, 1, 0 })]
        [InlineData(new[] { 1, 3, 3, 7, 9, 3, 8, 9, 8, 1, 3 })]
        [InlineData(new int[0])]
        public void DistinctCount_CorrectResult(int[] array)
        {
            int result = Lesson6.DistinctCount(array);

            int expected = array.Distinct().Count();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [InlineData(new[] { 10, 50, 5, 1 }, 0)]
        [InlineData(new[] { 10, 50 }, 0)]
        [InlineData(new[] { 20, 60, 70 }, 1)]
        [InlineData(new[] { 10 }, 0)]
        [InlineData(new[] { -10 }, 0)]
        [InlineData(new[] { 10, -50 }, 0)]
        [InlineData(new[] { 10, 2, -5, 1, -8, 20 }, 0)]
        [InlineData(new[] { 0, 0, 0, 0, 0 }, 0)]
        [InlineData(new[] { -10, -2, -5, -1, -8, -20 }, 0)]
        [InlineData(new int[] { }, 0)]
        public void Triangle_CorrectResult(int[] array, int expected)
        {
            int result = Lesson6.Triangle(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 8, 4, 2, 4, 5 })]
        [InlineData(new[] { 2, 1, 1, 2, 3, 1 })]
        [InlineData(new[] { 1 })]
        [InlineData(new[] { -1000000, 1000000 })]
        [InlineData(new[] { -1, -1, -5, 0, 8, -8 })]
        [InlineData(new[] { 1, 3, 2, 7, 1, 0 })]
        [InlineData(new[] { 1, 3, 3, 7, 9, 3, 8, 9, 8, 1, 3 })]
        [InlineData(new int[0])]
        public void Distinct_CorrectResult(int[] array)
        {
            int result = Lesson6.DistinctCount(array);

            int expected = array.Distinct().Count();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 8, 4, 2, 4, 5 }, 160)]
        [InlineData(new[] { 2, 1, 1, 2, 3, 1 }, 12)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 1, 2 }, 0)]
        [InlineData(new[] { 1, 2, 3 }, 6)]
        [InlineData(new[] { -1, -2, -3 }, -6)]
        [InlineData(new[] { -3, 1, 2, -2, 5, 6 }, 60)]
        [InlineData(new[] { -1, -3, 2, 5 }, 15)]
        [InlineData(new[] { -1000, 999, 1000 }, -999000000)]
        [InlineData(new[] { -1, -1, -5, 0, 8, -8 }, 320)]
        [InlineData(new[] { 1, 3, 2, 7, 1, 0 }, 42)]
        [InlineData(new[] { 1, 3, 3, 7, 9, 3, 8, 9, 8, 1, 3 }, 648)]
        [InlineData(new int[0], 0)]
        public void MaxProductOfThree_CorrectResult(int[] array, int expected)
        {
            int result = Lesson6.MaxProductOfThree(array);
            Assert.Equal(expected, result);
        }
    }
}
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
    }
}
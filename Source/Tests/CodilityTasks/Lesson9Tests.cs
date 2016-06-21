using System;
using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson9Tests
    {
        [Theory]
        [InlineData(new [] { 5, -7, 3, 5, -2, 4, -1 }, 10)]
        [InlineData(new int[] {}, 0)]
        public void SlowMaxSlice_CorrectResult(int[] array, int expected)
        {
            int result = Lesson9.SlowMaxSlice(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 5, -7, 3, 5, -2, 4, -1 }, 10)]
        [InlineData(new int[] { }, 0)]
        public void QuadraticMaxSlice1_CorrectResult(int[] array, int expected)
        {
            int result = Lesson9.QuadraticMaxSlice1(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 5, -7, 3, 5, -2, 4, -1 }, 10)]
        [InlineData(new int[] { }, 0)]
        public void QuadraticMaxSlice2_CorrectResult(int[] array, int expected)
        {
            int result = Lesson9.QuadraticMaxSlice2(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 5, -7, 3, 5, -2, 4, -1 }, 10)]
        [InlineData(new int[] { }, 0)]
        public void GoldenMaxSlice_CorrectResult(int[] array, int expected)
        {
            int result = Lesson9.GoldenMaxSlice(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 23171, 21011, 21123, 21366, 21013, 21367 }, 356)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new [] { 1 }, 0)]
        [InlineData(new [] { 1, 2 }, 1)]
        [InlineData(new [] { 2, 2 }, 0)]
        public void MaxProfit_CorrectResult(int[] array, int expected)
        {
            int result = Lesson9.MaxProfit(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(200000)]
        public void MaxProfit_LargeRange_CorrectResult(int n)
        {
            int[] array = Enumerable.Range(1, n).ToArray();
            var result = Lesson9.MaxProfit(array);
            Assert.Equal(n - 1, result);
        }

        [Theory]
        [InlineData(new[] { -1, 3, -4, 5, 1, -6, 2, 1 }, 1)]
        [InlineData(new int[] { }, -1)]
        [InlineData(new [] { 1 }, 0)]
        [InlineData(new [] { 0 }, 0)]
        [InlineData(new [] { 1, 0 }, 0)]
        [InlineData(new [] { 1, 1 }, -1)]
        public void Equi_CorrectResult(int[] array, int expected)
        {
            int result = Lesson9.Equi(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]
        [InlineData(new[] { 3, 2, 6 }, 2)]
        public void MaxDoubleSliceSum_CorrectResult(int[] array, int expected)
        {
            int result = Lesson9.MaxDoubleSliceSum(array);
            Assert.Equal(expected, result);
        }
    }
}
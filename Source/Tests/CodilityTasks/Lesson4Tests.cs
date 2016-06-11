using System;
using System.Linq;
using System.Security.Authentication;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson4Tests
    {
        [Theory]
        [InlineData(new[] { 0, 0, 4, 2, 4, 5 }, 5, new[] { 2, 0, 1, 0, 2, 1 })]
        public void CountingOccurrences_PositiveArray_CorrectResult(int[] array, int m, int[] expected)
        {
            var result = Lesson4.CountingOccurrences(array, m);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 0, 4, 2, 4, 5 }, new[] { 2, 0, 1, 0, 2, 1 }, false)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 3, 2, 4, 5 }, true)]
        public void SwapSlowSolution_CorrectResult(int[] arrayA, int[] arrayB, bool expected)
        {
            var result = Lesson4.SwapSlowSolution(arrayA, arrayB);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, new[] { 2, 0, 1, 0, 2, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 3, 2, 4 })]
        public void SwapSlowSolution_WrongArrays_Throws_ArgumentOutOfRangeException(int[] arrayA, int[] arrayB)
        {
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => Lesson4.SwapSlowSolution(arrayA, arrayB));
        }

        [Theory]
        [InlineData(new[] { 2, 0, 1, 0, 2, 1 }, new[] { 0, 0, 4, 2, 4, 5 }, 5, false)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 3, 2, 4, 5 }, 5, true)]
        public void SwapFastSolution_CorrectResult(int[] arrayA, int[] arrayB, int m, bool expected)
        {
            var result = Lesson4.SwapFastSolution(arrayA, arrayB, m);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, new[] { 2, 0, 1, 0, 2, 1 }, 5)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 3, 2, 4 }, 5)]
        public void SwapFastSolution_WrongArrays_Throws_ArgumentOutOfRangeException(int[] arrayA, int[] arrayB, int m)
        {
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => Lesson4.SwapFastSolution(arrayA, arrayB, m));
        }
    }
}
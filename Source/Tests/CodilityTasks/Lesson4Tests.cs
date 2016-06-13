using System;
using System.Collections;
using System.Collections.Generic;
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
            Assert.Throws<ArgumentOutOfRangeException>(() => Lesson4.SwapSlowSolution(arrayA, arrayB));
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
            Assert.Throws<ArgumentOutOfRangeException>(() => Lesson4.SwapFastSolution(arrayA, arrayB, m));
        }

        [Theory]
        [InlineData(new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 5, 6)]
        [InlineData(new[] { 1, 3, 1, 4, 2, 3, 5, 4, 1, 3, 1, 4, 2, 3, 5, 4 }, 5, 6)]
        [InlineData(new[] { 1, 3, 1, 4, 3, 5, 4, 1, 3, 1, 4, 2, 3, 5, 4 }, 5, 11)]
        [InlineData(new[] { 1, 3, 1, 4, 3, 5, 4 }, 5, -1)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 5, 4, 3, 5 }, 5, 4)]
        [InlineData(new[] { 1 }, 1, 0)]
        public void FrogRiverOne_CorrectResult(int[] array, int x, int expected)
        {
            var result = Lesson4.FrogRiverOne(x, array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 2, 4, 5 }, 1)]
        [InlineData(new[] { 4, 1, 3, 2 }, 1)]
        [InlineData(new[] { 4, 1, 3 }, 0)]
        [InlineData(new[] { 1, 3, 1, 4, 2 }, 0)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 1 }, 0)]
        [InlineData(new[] { 2 }, 0)]
        [InlineData(new[] { 2, 1 }, 1)]
        [InlineData(new[] { 1, 3 }, 0)]
        [InlineData(new[] { 2, 3 }, 0)]
        public void PermCheck_CorrectResult(int[] array, int expected)
        {
            var result = Lesson4.PermCheck(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 2, 4, 5 }, 6)]
        [InlineData(new[] { -1, -3, -6, -4, -5 }, 1)]
        [InlineData(new[] { -1, -3, -2, -4, -5 }, 1)]
        [InlineData(new[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [InlineData(new[] { 5, 1, 3, 2 }, 4)]
        [InlineData(new[] { 5, 1, 1, 3, 2 }, 4)]
        [InlineData(new[] { -117008, -117006, 1, 3, 2, 4 }, 5)]
        [InlineData(new[] { 2 }, 1)]
        [InlineData(new[] { 3 }, 1)]
        [InlineData(new[] { 1 }, 2)]
        [InlineData(new[] { 0 }, 1)]
        [InlineData(new[] { -1 }, 1)]
        [InlineData(new[] { -2147483648 }, 1)]
        [InlineData(new[] { -10 }, 1)]
        [InlineData(new[] { -10, -8 }, 1)]
        [InlineData(new[] { 1, 3 }, 2)]
        [InlineData(new[] { 1, 2 }, 3)]
        [InlineData(new[] { 2, 3 }, 1)]
        public void MissingInteger_CorrectResult(int[] array, int expected)
        {
            var result = Lesson4.MissingInteger(array);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PermMissingElem_LargeRange_CorrectResult()
        {
            int n = 100;
            List<int> list1 = Enumerable.Range(1, n).ToList();
            List<int> list2 = Enumerable.Range(n + 2, 2*n).ToList();
            list1.AddRange(list2);
            int[] array = list1.ToArray();

            var result = Lesson4.MissingInteger(array);

            Assert.Equal(n + 1, result);
        }

        [Fact]
        public void PermMissingElem_NegativeLargeRange_CorrectResult()
        {
            int n = 100;
            
            int[] array = Enumerable.Range(1, n).Select(x => -x).ToArray();

            var result = Lesson4.MissingInteger(array);

            Assert.Equal(1, result);
        }
    }
}
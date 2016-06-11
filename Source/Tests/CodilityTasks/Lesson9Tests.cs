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
    }
}
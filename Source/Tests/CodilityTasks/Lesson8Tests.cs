using System;
using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson8Tests
    {
        [Theory]
        [InlineData(new [] { 6, 8, 4, 6, 8, 6, 6 }, 6)]
        [InlineData(new [] { 6, 8, 6, 8, 6, 8, 6, 8 }, -1)]
        [InlineData(new [] { 6, 8, 6, 8, 6, 8, 6, 8, 8 }, 8)]
        [InlineData(new [] { 1, 0, 3, 7, 9 }, -1)]
        [InlineData(new int[] {}, -1)]
        public void SlowFindLeader_CorrectResult(int[] array, int expected)
        {
            int result = Lesson8.SlowFindLeader(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 6, 8, 4, 6, 8, 6, 6 }, 6)]
        [InlineData(new[] { 6, 8, 6, 8, 6, 8, 6, 8 }, -1)]
        [InlineData(new[] { 6, 8, 6, 8, 6, 8, 6, 8, 8 }, 8)]
        [InlineData(new[] { 1, 0, 3, 7, 9 }, -1)]
        [InlineData(new int[] { }, -1)]
        public void FastFindLeader_CorrectResult(int[] array, int expected)
        {
            int result = Lesson8.FastFindLeader(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 6, 8, 4, 6, 8, 6, 6 }, 6)]
        [InlineData(new[] { 6, 8, 6, 8, 6, 8, 6, 8 }, -1)]
        [InlineData(new[] { 6, 8, 6, 8, 6, 8, 6, 8, 8 }, 8)]
        [InlineData(new[] { 1, 0, 3, 7, 9 }, -1)]
        [InlineData(new int[] { }, -1)]
        public void GoldenFindLeader_CorrectResult(int[] array, int expected)
        {
            int result = Lesson8.GoldenFindLeader(array);
            Assert.Equal(expected, result);
        }
    }
}
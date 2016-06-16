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

        [Theory]
        [InlineData(new[] { 6, 8, 4, 6, 8, 6, 6 }, 0)]
        [InlineData(new[] { 4, 3, 4, 4, 4, 2 }, 2)]
        [InlineData(new[] { -4, 3, -4, -4, -4, 2 }, 2)]
        [InlineData(new [] { 1 }, 0)]
        [InlineData(new [] { 0 }, 0)]
        [InlineData(new [] { 1, 1 }, 1)]
        [InlineData(new [] { 1, 2 }, 0)]
        [InlineData(new [] { 1, 1, 1 }, 2)]
        [InlineData(new [] { 1, 7, 1 }, 0)]
        public void EquiLeader_CorrectResult(int[] array, int expected)
        {
            int result = Lesson8.EquiLeader(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 6, 8, 4, 6, 8, 6, 6 }, 0)]
        [InlineData(new[] { 3, 4, 3, 4, 4, 4, 2 }, 1)]
        [InlineData(new[] { 3, 4, 3, 2, 3, -1, 3, 3 }, 0)]
        [InlineData(new[] { -1, -4, 3, -4, -4, -4, 2 }, 1)]
        [InlineData(new int[] { }, -1)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 0 }, 0)]
        [InlineData(new[] { 1, 1 }, 0)]
        [InlineData(new[] { 1, 2 }, -1)]
        [InlineData(new[] { 1, 1, 1 }, 0)]
        [InlineData(new[] { 1, 7, 1 }, 0)]
        [InlineData(new[] { 0, 2, 1, 7, 1, 2, 1, 1, 1, 1 }, 2)]
        public void Dominator_CorrectResult(int[] array, int expected)
        {
            int result = Lesson8.Dominator(array);
            Assert.Equal(expected, result);
        }
    }
}
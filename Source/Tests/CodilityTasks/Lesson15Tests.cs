using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson15Tests
    {
        [Theory]
        [InlineData(new[] { 6, 2, 7, 4, 1, 3, 6 }, 12, true)]
        [InlineData(new[] { 6, 2, 7, 4, 1, 3, 6 }, 30, false)]
        public void CaterpillarMethod_CorrectResult(int[] array, int s, bool expected)
        {
            bool result = Lesson15.CaterpillarMethod(array, s);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 4, 5, 6, 9, 11 }, 10)]
        public void Triangles_CorrectResult(int[] array, int expected)
        {
            int result = Lesson15.Triangles(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { -5, -3, -1, 0, 3, 6 }, 5)]
        [InlineData(new[] { -5 }, 1)]
        [InlineData(new[] { -5, 5 }, 1)]
        [InlineData(new[] { -5, 1, 5 }, 2)]
        [InlineData(new[] { -5, -1, 1, 5 }, 2)]
        public void AbsDistinct_CorrectResult(int[] array, int expected)
        {
            int result = Lesson15.AbsDistinct(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, new[] { 3, 4, 5, 5, 2 }, 9)]
        [InlineData(6, new[] { 3, 4, 5, 5, 2, 3, 5, 6, 6, 1, 2 }, 25)]
        [InlineData(0, new[] { 0 }, 1)]
        [InlineData(0, new[] { 0, 0 }, 2)]
        [InlineData(1, new[] { 0, 1 }, 3)]
        public void CountDistinctSlices_CorrectResult(int m, int[] array, int expected)
        {
            int result = Lesson15.CountDistinctSlices(m, array);
            Assert.Equal(expected, result);
        }
    }
}
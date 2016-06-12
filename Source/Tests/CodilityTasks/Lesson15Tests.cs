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
    }
}
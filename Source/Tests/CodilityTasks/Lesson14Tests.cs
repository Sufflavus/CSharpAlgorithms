using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson14Tests
    {
        [Theory]
        [InlineData(new[] { 12, 15, 15, 19, 24, 31, 53, 59, 60 }, 31, 5)]
        [InlineData(new[] { 12, 15, 15, 19, 24, 31, 53, 59, 60 }, 20, 3)]
        public void BinarySearch_CorrectResult(int[] array, int x, int expected)
        {
            int result = Lesson14.BinarySearch(array, x);
            Assert.Equal(expected, result);
        }

        /*[Theory]
        [InlineData(new double[] { 0.12, 0.15, 0.15, 0.19, 0.24, 0.31, 0.53, 0.59, 0.60 }, 5, 5)]
        public void Boards_CorrectResult(double[] array, int k, double expected)
        {
            double result = Lesson14.Boards(array, k);
            Assert.Equal(expected, result);
        }*/
    }
}
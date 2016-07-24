using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson16Tests
    {
        [Theory]
        [InlineData(new[] {1, 3, 4, 5, 6, 9, 11}, 13, 4)]
        public void GreedyCanoeistB_CorrectResult(int[] w, int k, int expected)
        {
            int result = Lesson16.GreedyCanoeistB(w, k);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, new[] { 1, 2, 3, 4, 1, 1, 3 }, 3)]
        [InlineData(1, new[] { 1 }, 1)]
        public void TieRopes_CorrectResult(int k, int[] array, int expected)
        {
            int result = Lesson16.TieRopes(k, array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 7, 9, 9 }, new[] { 5, 6, 8, 9, 10 }, 3)]
        public void MaxNonoverlappingSegments_CorrectResult(int[] arrayA, int[] arrayB, int expected)
        {
            int result = Lesson16.MaxNonoverlappingSegments(arrayA, arrayB);
            Assert.Equal(expected, result);
        }
    }
}
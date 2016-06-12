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
    }
}
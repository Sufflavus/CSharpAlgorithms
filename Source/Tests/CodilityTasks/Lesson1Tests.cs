using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson1Tests
    {
        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(1041, 5)]
        public void SlowBinaryGap_CorrectResult(int n, int expected)
        {
            var result = Lesson1.SlowBinaryGap(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(1041, 5)]
        public void FastBinaryGap_CorrectResult(int n, int expected)
        {
            var result = Lesson1.FastBinaryGap(n);
            Assert.Equal(expected, result);
        }
    }
}
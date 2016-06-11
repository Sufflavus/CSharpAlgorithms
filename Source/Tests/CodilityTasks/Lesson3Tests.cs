using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson3Tests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(2534)]
        public void CountTotalSlowSolution_PositiveN_CorrectResult(int n)
        {
            var result = Lesson3.CountTotalSlowSolution(n);

            int expected = CountTotal(n);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountTotalSlowSolution_NegativeN_CorrectResult()
        {
            var result = Lesson3.CountTotalSlowSolution(-10);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountTotalSlowSolution_Zero_CorrectResult()
        {
            var result = Lesson3.CountTotalSlowSolution(0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(2534)]
        public void CountTotalFastSolution_PositiveN_CorrectResult(int n)
        {
            var result = Lesson3.CountTotalFastSolution(n);

            int expected = CountTotal(n);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountTotalFastSolution_NegativeN_CorrectResult()
        {
            var result = Lesson3.CountTotalFastSolution(-10);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountTotalFastSolution_Zero_CorrectResult()
        {
            var result = Lesson3.CountTotalFastSolution(0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(2534)]
        public void CountTotalSuperFastSolution_PositiveN_CorrectResult(int n)
        {
            var result = Lesson3.CountTotalSuperFastSolution(n);

            int expected = CountTotal(n);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountTotalSuperFastSolution_NegativeN_CorrectResult()
        {
            var result = Lesson3.CountTotalSuperFastSolution(-10);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountTotalSuperFastSolution_Zero_CorrectResult()
        {
            var result = Lesson3.CountTotalSuperFastSolution(0);
            Assert.Equal(0, result);
        }

        private int CountTotal(int n)
        {
            return Enumerable.Range(1, n).Sum(x => x);
        }
    }
}
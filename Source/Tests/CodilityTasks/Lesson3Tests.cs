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

        [Theory]
        [InlineData(10, 85, 30, 3)]
        [InlineData(10, 11, 20, 1)]
        [InlineData(10, 30, 20, 1)]
        [InlineData(10, 25, 20, 1)]
        [InlineData(1, 1, 1, 0)]
        [InlineData(10, 10, 10, 0)]
        public void FrogJmp_CorrectResult(int x, int y, int d, int expected)
        {
            var result = Lesson3.FrogJmp(x, y, d);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 3, 1, 2, 4, 3 }, 1)]
        [InlineData(new[] { -3, -1, -2, -4, -3 }, 1)]
        [InlineData(new[] { 3, 1 }, 2)]
        [InlineData(new[] { 0, 0 }, 0)]
        [InlineData(new[] { 1, 1 }, 0)]
        [InlineData(new[] { 3000, 1000 }, 2000)]
        public void TapeEquilibrium_CorrectResult(int[] array, int expected)
        {
            var result = Lesson3.TapeEquilibrium(array);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new[] { 3, 1, 2, 4, 6 }, 5)]
        [InlineData(new[] { 3, 5, 2, 4, 6 }, 1)]
        [InlineData(new[] { 3, 5, 2, 4, 1 }, 6)]
        [InlineData(new[] { 2, 3, 1, 5 }, 4)]
        [InlineData(new[] { 1, 2 }, 3)]
        [InlineData(new[] { 2 }, 1)]
        [InlineData(new[] { 1 }, 2)]
        [InlineData(new int[] { }, 1)]
        public void PermMissingElem_CorrectResult(int[] array, int expected)
        {
            var result = Lesson3.PermMissingElem(array);
            Assert.Equal(expected, result);
        }

        public void PermMissingElem_LargeRange_CorrectResult()
        {
            int n = 10000;
            int[] array = Enumerable.Range(1, n).ToArray();

            var result = Lesson3.PermMissingElem(array);
             
            Assert.Equal(n + 1, result);
        }

        private int CountTotal(int n)
        {
            return Enumerable.Range(1, n).Sum(x => x);
        }
    }
}
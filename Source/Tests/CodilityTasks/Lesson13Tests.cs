using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson13Tests
    {
        [Theory]
        [InlineData(11, 89)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        public void Fibonacci_CorrectResult(int n, int expected)
        {
            int result = Lesson13.Fibonacci(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(11, 89)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        public void FibonacciDynamic_CorrectResult(int n, int expected)
        {
            int result = Lesson13.FibonacciDynamic(n);
            Assert.Equal(expected, result);
        }
    }
}
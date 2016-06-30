using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson11Tests
    {
        [Theory]
        [InlineData(17,
            new []
            {
                false, false, true, true, false, true, false, true, false, false, false, true, false, true, false, false,
                false, true
            })]
        public void GroceryStore_CorrectResult(int n, bool[] expected)
        {
            bool[] result = Lesson11.Sieve(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(17, new [] {17})]
        [InlineData(16, new [] {2, 2, 2, 2})]
        public void Factorization_CorrectResult(int n, int[] expected)
        {
            int[] result = Lesson11.Factorization(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(26, new [] {1, 4, 16}, new[] { 26, 10, 20 }, new[] { 10, 4, 0 })]
        [InlineData(1, new [] { 1 }, new[] { 1 }, new[] { 0 })]
        [InlineData(2, new [] { 1 }, new[] { 2 }, new[] { 0 })]
        [InlineData(3, new [] { 1 }, new[] { 3 }, new[] { 0 })]
        [InlineData(4, new [] { 1 }, new[] { 4 }, new[] { 1 })]
        [InlineData(4, new [] { 1, 2 }, new[] { 4, 3 }, new[] { 1, 0 })]
        [InlineData(5, new [] { 1, 2 }, new[] { 4, 5 }, new[] { 1, 1 })]
        public void CountSemiprimes_CorrectResult(int n, int[] p, int[] q, int[] expected)
        {
            int[] result = Lesson11.CountSemiprimes(n, p, q);
            Assert.Equal(expected, result);
        }
    }
}
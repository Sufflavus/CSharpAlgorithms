using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson11Tests
    {
        [Theory]
        [InlineData(17,
            new bool[]
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
        [InlineData(17, new int[] {17})]
        [InlineData(16, new int[] {2, 2, 2, 2})]
        public void Factorization_CorrectResult(int n, int[] expected)
        {
            int[] result = Lesson11.Factorization(n);
            Assert.Equal(expected, result);
        }
    }
}
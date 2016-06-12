using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson12Tests
    {
        [Theory]
        [InlineData(10, 15, 5)]
        [InlineData(13, 15, 1)]
        [InlineData(20, 20, 20)]
        public void Gcd1_CorrectResult(int a, int b, int expected)
        {
            int result = Lesson12.Gcd1(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 15, 5)]
        [InlineData(13, 15, 1)]
        [InlineData(20, 20, 20)]
        public void Gcd2_CorrectResult(int a, int b, int expected)
        {
            int result = Lesson12.Gcd2(a, b);
            Assert.Equal(expected, result);
        }

        /*[Theory]
        [InlineData(10, 15, 5)]
        [InlineData(13, 15, 1)]
        [InlineData(20, 20, 20)]
        public void Gcd3_CorrectResult(int a, int b, int expected)
        {
            int result = Lesson12.Gcd3(a, b, 1);
            Assert.Equal(expected, result);
        }*/

        [Theory]
        [InlineData(10, 15, 30)]
        [InlineData(20, 20, 20)]
        public void Lcm_CorrectResult(int a, int b, int expected)
        {
            int result = Lesson12.Lcm(a, b);
            Assert.Equal(expected, result);
        }
    }
}
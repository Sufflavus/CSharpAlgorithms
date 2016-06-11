using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson2Tests
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5}, new[] {5, 4, 3, 2, 1})]
        [InlineData(new[] {-1, -2, 3, 5, 7}, new[] {7, 5, 3, -2, -1})]
        [InlineData(new[] {1, 2, 3, 4}, new[] {4, 3, 2, 1})]
        [InlineData(new[] {5, 4, 3, 2, 1}, new[] {1, 2, 3, 4, 5})]
        [InlineData(new[] {5, 4, 3, 2}, new[] {2, 3, 4, 5})]
        public void RevertArray_NotEmptyArray_Reverted(int[] input, int[] expected)
        {
            var result = Lesson2.RevertArray(input);

            for (var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        public void RevertArray_EmptyArray()
        {
            var result = Lesson2.RevertArray(new int[] {});
            Assert.Equal(0, result.Length);
        }
    }
}
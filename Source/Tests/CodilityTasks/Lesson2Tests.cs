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
            Assert.Equal(expected, result);
        }

        public void RevertArray_EmptyArray()
        {
            var result = Lesson2.RevertArray(new int[] {});
            Assert.Equal(0, result.Length);
        }

        [Theory]
        [InlineData(new[] { 1 }, 3, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, 1, new[] { 2, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 0, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { -1, -2, 3, 5, 7 }, 1, new[] { 7, -1, -2, 3, 5 })]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 1, new[] { 6, 3, 8, 9, 7 })]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 8, new[] { 9, 7, 6, 3, 8 })]
        public void RotateArray_NotEmptyArray_Rotated(int[] input, int k, int[] expected)
        {
            var result = Lesson2.RotateArray(input, k);
            Assert.Equal(expected, result);
        }

        public void RotateArray_EmptyArray()
        {
            var result = Lesson2.RotateArray(new int[] { }, 1);
            Assert.Equal(0, result.Length);
        }
    }
}
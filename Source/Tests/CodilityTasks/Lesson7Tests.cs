using System;
using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson7Tests
    {
        [Theory]
        [InlineData(new byte[] { 0, 0, 1, 0, 1, 1, 0, 0 }, 0)]
        [InlineData(new byte[] { 1, 1, 1, 0, 1, 1, 0, 1, 1 }, 5)]
        public void GroceryStore_CorrectResult(byte[] array, int expected)
        {
            int result = Lesson7.GroceryStore(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("{[()()]}", 1)]
        [InlineData("{[()]}()[]{}(())", 1)]
        [InlineData("([)()]", 0)]
        [InlineData("(", 0)]
        [InlineData("()", 1)]
        [InlineData("[", 0)]
        [InlineData("[]", 1)]
        [InlineData("{", 0)]
        [InlineData("{}", 1)]
        [InlineData(")", 0)]
        [InlineData("]", 0)]
        [InlineData("}", 0)]
        [InlineData("[]]]]]]]", 0)]
        [InlineData("", 1)]
        public void Brackets_CorrectResult(string s, int expected)
        {
            int result = Lesson7.Brackets(s);
            Assert.Equal(expected, result);
        }
    }
}
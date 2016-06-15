using System;
using System.Collections.Generic;
using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson7Tests
    {
        [Theory]
        [InlineData(new byte[] {0, 0, 1, 0, 1, 1, 0, 0}, 0)]
        [InlineData(new byte[] {1, 1, 1, 0, 1, 1, 0, 1, 1}, 5)]
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
        
        [Theory]
        [InlineData(new[] {4, 3, 2, 1, 5}, new[] {0, 1, 0, 0, 0}, 2)]
        [InlineData(new[] {4, 3, 2, 1, 5}, new[] {0, 1, 0, 1, 0}, 2)]
        [InlineData(new[] {4, 3, 2, 8, 5}, new[] {0, 1, 0, 1, 0}, 3)]
        [InlineData(new[] {4, 3, 2, 1, 5, 6, 7, 9}, new[] {0, 1, 0, 1, 0, 0, 1, 0}, 4)]
        [InlineData(new[] {0}, new[] {0}, 1)]
        [InlineData(new[] {5}, new[] {0}, 1)]
        [InlineData(new[] {1}, new[] {1}, 1)]
        [InlineData(new[] {1, 2}, new[] {1, 0}, 1)]
        [InlineData(new[] {3, 2}, new[] {1, 0}, 1)]
        [InlineData(new[] {3, 2}, new[] {0, 1}, 2)]
        [InlineData(new[] {3, 5}, new[] {0, 1}, 2)]
        public void Fish_CorrectResult(int[] arrayA, int[] arrayB, int expected)
        {
            int result = Lesson7.Fish(arrayA, arrayB);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(100000)]
        public void Fish_LargeRange_CorrectResult(int n)
        {
            int[] arrayA = Enumerable.Range(0, n - 1).ToArray();
            int[] arrayB = Enumerable.Range(0, n - 1).Select(x => x%2).ToArray();

            var result = Lesson7.Fish(arrayA, arrayB);

            Assert.Equal(n/2, result);
        }

        [Theory]
        [InlineData("((()()))", 1)]
        [InlineData("((()))()()()(())", 1)]
        [InlineData("(((()))()()(())))", 0)]
        [InlineData("()())", 0)]
        [InlineData("(", 0)]
        [InlineData("((", 0)]
        [InlineData("()", 1)]
        [InlineData(")", 0)]
        [InlineData("()))))))", 0)]
        [InlineData("", 1)]
        public void Nesting_CorrectResult(string s, int expected)
        {
            int result = Lesson7.Brackets(s);
            Assert.Equal(expected, result);
        }
    }
}
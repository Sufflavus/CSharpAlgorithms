using System;
using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson10Tests
    {
        [Theory]
        [InlineData(36, 9)]
        [InlineData(37, 2)]
        [InlineData(40, 8)]
        [InlineData(0, 0)]
        [InlineData(-40, 0)]
        public void DivisorsCount_CorrectResult(int n, int expected)
        {
            int result = Lesson10.DivisorsCount(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(37, true)]
        [InlineData(101, true)]
        [InlineData(36, false)]
        [InlineData(40, false)]
        public void IsPrime_CorrectResult(int n, bool expected)
        {
            bool result = Lesson10.IsPrime(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 3)]
        public void ReverseCoins_CorrectResult(int n, int expected)
        {
            int result = Lesson10.ReverseCoins(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(30, 22)]
        [InlineData(1, 4)]
        [InlineData(2, 6)]
        [InlineData(1000000000, 126500)]
        public void MinPerimeterRectangle_CorrectResult(int n, int expected)
        {
            int result = Lesson10.MinPerimeterRectangle(n);
            Assert.Equal(expected, result);
        }
    }
}
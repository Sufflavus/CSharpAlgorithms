using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CodilityTasks;
using Xunit;

namespace Tests.CodilityTasks
{
    public class Lesson5Tests
    {
        [Theory]
        [InlineData(new[] { 1, 8, 4, 2, 4, 5 })]
        [InlineData(new[] { 1, -8, 4, 2, -4, 5 })]
        public void CountingOccurrences_PositiveArray_CorrectResult(int[] array)
        {
            Int64[] result = Lesson5.PrefixSums(array);

            Assert.Equal(array.Length + 1, result.Length);

            Int64 expected = 0;
            for (int i = 0; i < array.Length; i++)
            {
                expected += array[i];
                Assert.Equal(expected, result[i + 1]);
            }
        }

        [Theory]
        [InlineData(new[] { 1, 8, 4, 2, 4, 5, 9, 1, -3 }, 3, 7)]
        public void CountTotal_CorrectResult(int[] array, int x, int y)
        {
            Int64[] prefixSums = Lesson5.PrefixSums(array);

            Int64 result = Lesson5.CountTotal(prefixSums, x, y);

            Int32 expected = 0;
            for (int i = x; i <= y; i++)
            {
                expected += array[i];
            }

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, -1, 3)]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, 1, -3)]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, 10, 3)]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, 1, 13)]
        public void CountTotal_WrongArrays_Throws_ArgumentOutOfRangeException(int[] array, int x, int y)
        {
            Int64[] prefixSums = Lesson5.PrefixSums(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => Lesson5.CountTotal(prefixSums, x, y));
        }

        [Theory]
        [InlineData(new[] { 2, 3, 7, 5, 1, 3, 9 }, 4, 6)]
        public void MushroomPicker_CorrectResult(int[] array, int k, int m)
        {
            Int64 result = Lesson5.MushroomPicker(array, k, m);
            Assert.Equal(25, result);
        }

        [Theory]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, -1, 3)]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, 1, -3)]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, 10, 3)]
        [InlineData(new[] { 0, 0, 4, 2, 4 }, 1, 13)]
        public void MushroomPicker_WrongArrays_Throws_ArgumentOutOfRangeException(int[] array, int k, int m)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Lesson5.MushroomPicker(array, k, m));
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 1, 1 }, 5)]
        [InlineData(new[] { 0, 1, 0, 1, 1, 0, 0 }, 5)]
        [InlineData(new[] { 0 }, 0)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 1, 0 }, 0)]
        [InlineData(new[] { 0, 1 }, 1)]
        [InlineData(new[] { 0, 0 }, 0)]
        [InlineData(new[] { 1, 1 }, 0)]
        [InlineData(new[] { 0, 0, 1 }, 2)]
        [InlineData(new[] { 0, 1, 1 }, 2)]
        [InlineData(new[] { 1, 0, 0 }, 0)]
        [InlineData(new[] { 1, 1, 0 }, 0)]
        public void PassingCars_CorrectResult(int[] array, int expected)
        {
            int result = Lesson5.PassingCars(array);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(100000)]
        public void PassingCars_LargeRange_CorrectResult(int n)
        {
            List<int> list1 = new List<int> {0};
            List<int> list2 = Enumerable.Range(1, n - 1).Select(x => 1).ToList();
            list1.AddRange(list2);
            int[] array = list1.ToArray();

            var result = Lesson5.PassingCars(array);

            Assert.Equal(n - 1, result);
        }

        [Fact]
        public void PassingCars_MegaLargeRange_CorrectResult()
        {
            int n = 100000;
            int[] array = Enumerable.Range(1, n).Select(x => x % 2).ToArray();

            var result = Lesson5.PassingCars(array);

            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData(6, 11, 2, 3)]
        [InlineData(6, 12, 2, 4)]
        [InlineData(7, 11, 2, 2)]
        [InlineData(7, 12, 2, 3)]
        [InlineData(8, 12, 2, 3)]
        [InlineData(6, 11, 3, 2)]
        [InlineData(6, 6, 2, 1)]
        [InlineData(6, 6, 5, 0)]
        [InlineData(6, 16, 1, 11)]
        [InlineData(100, 250, 2, 76)]
        [InlineData(0, 300, 15, 21)]
        [InlineData(0, 300, 3, 101)]
        [InlineData(4, 300, 5, 60)]
        [InlineData(11, 345, 17, 20)]
        [InlineData(0, 0, 11, 1)]
        [InlineData(10, 10, 5, 1)]
        [InlineData(10, 10, 7, 0)]
        [InlineData(10, 10, 20, 0)]
        [InlineData(100, 123000000, 2, 61499951)]
        [InlineData(100, 123000000, 10000, 12300)]
        [InlineData(1000000, 2000000000, 17, 117588235)]
        public void CountDiv_CorrectResult(int a, int b, int k, int expected)
        {
            int result = Lesson5.CountDiv(a, b, k);
            Assert.Equal(expected, result);
        }
    }
}
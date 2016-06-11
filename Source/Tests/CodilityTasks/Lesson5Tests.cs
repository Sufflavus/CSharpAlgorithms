using System;
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
    }
}
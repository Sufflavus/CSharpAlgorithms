using System;

namespace CodilityTasks
{
    public static class Lesson9
    {
        public static int SlowMaxSlice(int[] array)
        {
            int n = array.Length;
            int result = 0;
            for (int p = 0; p < n; p++)
            {
                for (int q = p; q < n; q++)
                {
                    int sum = 0;
                    for (int i = p; i < q + 1; i++)
                    {
                        sum += array[i];
                    }
                    result = Math.Max(result, sum);
                }
            }
            return result;
        }

        public static int QuadraticMaxSlice1(int[] array)
        {
            int n = array.Length;
            int result = 0;
            Int64[] prefixSums = Lesson5.PrefixSums(array);
            for (int p = 0; p < n; p++)
            {
                for (int q = p; q < n; q++)
                {
                    Int32 sum = (int) (prefixSums[q + 1] - prefixSums[p]);
                    result = Math.Max(result, sum);
                }
            }
            return result;
        }

        public static int QuadraticMaxSlice2(int[] array)
        {
            int n = array.Length;
            int result = 0;
            for (int p = 0; p < n; p++)
            {
                int sum = 0;
                for (int q = p; q < n; q++)
                {
                    sum += array[q];
                    result = Math.Max(result, sum);
                }
            }
            return result;
        }

        public static int GoldenMaxSlice(int[] array)
        {
            int maxEnding = 0;
            int maxSlice = 0;
            foreach (var a in array)
            {
                maxEnding = Math.Max(0, maxEnding + a);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }
            return maxSlice;
        }
    }
}
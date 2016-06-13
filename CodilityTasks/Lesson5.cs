using System;

namespace CodilityTasks
{
    public static class Lesson5
    {
        /// <summary>
        /// consecutive totals of the first 0, 1, 2, ... , n elements of an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static Int64[] PrefixSums(int[] array)
        {
            int n = array.Length;
            Int64[] p = new Int64[n + 1];
            for (int k = 1; k < n + 1; k++)
            {
                p[k] = p[k - 1] + array[k - 1];
            }
            return p;
        }

        /// <summary>
        /// totals of m slices [x..y]
        /// </summary>
        /// <param name="prefixSums"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Int64 CountTotal(Int64[] prefixSums, int x, int y)
        {
            if (x < 0 || y < 0 || x > prefixSums.Length || y > prefixSums.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            return prefixSums[y + 1] - prefixSums[x];
        }

        /// <summary>
        /// You are given a non-empty, zero-indexed array A of n (1 more_than n less_than 100 000) integers
        /// a[0], a[1], . . . , a[n−1] (0 more_than a[i] less_than 1 000). This array represents number of mushrooms growing on the
        /// consecutive spots along a road.You are also given integers k and m that are less than n.
        /// A mushroom picker is at spot number k on the road and should perform m moves.In
        /// one move she moves to an adjacent spot. She collects all the mushrooms growing on spots
        /// she visits. The goal is to calculate the maximum number of mushrooms that the mushroom
        /// picker can collect in m moves.
        /// For example, consider array A such that:
        /// 2 3 7 5 1 3 9
        /// 0 1 2 3 4 5 6
        /// The mushroom picker starts at spot k = 4 and should perform m = 6 moves.She might
        /// move to spots 3, 2, 3, 4, 5, 6 and thereby collect 1 + 5 + 7 + 3 + 9 = 25 mushrooms.This is the
        /// maximal number of mushrooms she can collect.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Int64 MushroomPicker(int[] array, int k, int m)
        {
            if (k < 0 || m < 0 || k > array.Length || m > array.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            int n = array.Length;
            Int64 result = 0;
            Int64[] prefixSums = PrefixSums(array);
            for (int p = 0; p < Math.Min(m, k) + 1; p++)
            {
                int leftPos = k - p;
                int rightPos = Math.Min(n - 1, Math.Max(k, k + m - 2*p));
                result = Math.Max(result, CountTotal(prefixSums, leftPos, rightPos));
            }
            for (int p = 0; p < Math.Min(m + 1, n - k); p++)
            {
                int leftPos = k + p;
                int rightPos = Math.Max(0, Math.Min(k, k - (m - 2 * p)));
                result = Math.Max(result, CountTotal(prefixSums, leftPos, rightPos));
            }
            return result;
        }

        public static int PassingCars(int[] array)
        {
            int n = array.Length;
            int[] prefixSums = PrefixSums1(array);
            int couplesCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    int rightSum = GetSum(prefixSums, i + 1, n - 1);
                    couplesCount += rightSum;
                    if (couplesCount > 1000000000)
                    {
                        return -1;
                    }
                }
            }
            return couplesCount;
        }

        /// <summary>
        /// given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K
        /// </summary>
        /// <param name="a">A and B are integers within the range [0..2,000,000,000]</param>
        /// <param name="b">A less_or_equal B</param>
        /// <param name="k">K is an integer within the range[1..2, 000, 000, 000]</param>
        /// <returns></returns>
        public static int CountDiv(int a, int b, int k)
        {
            if (a%k == 0 || b%k == 0)
            {
                return (b - a)/k + 1;
            }
            return b/k - a/k;
        }
        
        private static int[] PrefixSums1(int[] array)
        {
            int n = array.Length;
            int[] p = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                p[i] = p[i - 1] + array[i - 1];
            }
            return p;
        }

        private static int GetSum(int[] prefixSums, int start, int end)
        {
            return prefixSums[end + 1] - prefixSums[start];
        }
    }
}

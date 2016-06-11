using System;

namespace CodilityTasks
{
    public static class Lesson5
    {
        /// <summary>
        /// consecutive totals of the first 0, 1, 2, . . . , n elements of an array
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
    }
}

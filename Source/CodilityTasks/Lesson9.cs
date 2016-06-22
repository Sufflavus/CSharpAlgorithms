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

        /// <summary>
        /// given a zero-indexed array A consisting of N integers containing daily prices of a stock share for a period 
        /// of N consecutive days, returns the maximum possible profit from one transaction during this period. 
        /// The function should return 0 if it was impossible to gain any profit.
        /// </summary>
        /// <param name="array">N is an integer within the range [0..400,000];
        /// each element of array A is an integer within the range[0..200, 000].</param>
        /// <returns>https://codility.com/demo/results/training2RUFKJ-GGS/</returns>
        public static int MaxProfit(int[] array)
        {
            int n = array.Length;

            if (n < 2)
            {
                return 0;
            }

            int minPrice = array[0];
            int maxOnStep = 0;
            int maxProfit = 0;
            for (int i = 1; i < n; i++)
            {
                maxOnStep = Math.Max(array[i] - minPrice, 0);
                minPrice = Math.Min(minPrice, array[i]);
                maxProfit = Math.Max(maxOnStep, maxProfit);
            }
            return maxProfit;
        }

        /// <summary>
        /// given a zero-indexed array A consisting of N integers, returns any of its equilibrium indices. 
        /// The function should return −1 if no equilibrium index exists.
        /// A zero-indexed array A consisting of N integers is given. An equilibrium index of this array is any integer P such that 0 ≤ P < N and the sum of elements of lower indices is equal to the sum of elements of higher indices, i.e. 
        /// A[0] + A[1] + ... + A[P−1] = A[P + 1] + ... + A[N−2] + A[N−1].
        /// Sum of zero elements is assumed to be equal to 0. This can happen if P = 0 or if P = N−1.
        /// </summary>
        /// <param name="array">N is an integer within the range [0..100,000];
        /// each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647].</param>
        /// <returns>https://codility.com/demo/results/demoCMPJKC-7AP/</returns>
        public static int Equi(int[] array)
        {
            int n = array.Length;
            if (n == 0)
            {
                return -1;
            }
            Int64[] prefixSums = PrefixSums(array);
            for (int i = 0; i < n; i++)
            {
                Int64 leftSumm = i == 0 ? 0 : prefixSums[i];
                Int64 rightSumm = i == n - 1 ? 0 : prefixSums[n] - prefixSums[i + 1];
                if (leftSumm == rightSumm)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int MaxDoubleSliceSum(int[] array)
        {
            int n = array.Length;
            if (n == 3)
            {
                return 0;
            }
            int[] maxLeftSumm = new int[n];
            int[] maxRightSumm = new int[n];

            // Kadane's algorithm in forward direction
            for (var i = 1; i < n - 1; i++)
            {
                maxLeftSumm[i] = Math.Max(0, maxLeftSumm[i - 1] + array[i]);
            }

            // Kadane's algorithm in reverse direction
            for (var i = n - 2; i > 0; i--) 
            {
                maxRightSumm[i] = Math.Max(0, maxRightSumm[i + 1] + array[i]);
            }

            int max = 0;

            for (var i = 1; i < n - 1; i++)
            {
                var summ = maxLeftSumm[i - 1] + maxRightSumm[i + 1];
                if (summ > max)
                {
                    max = summ;
                }
            }
           
            return max;
        }

        private static Int64[] PrefixSums(int[] array)
        {
            int n = array.Length;
            Int64[] p = new Int64[n + 1];
            for (int k = 1; k < n + 1; k++)
            {
                p[k] = p[k - 1] + array[k - 1];
            }
            return p;
        }
    }
}
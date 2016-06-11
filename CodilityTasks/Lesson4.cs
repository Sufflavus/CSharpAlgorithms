using System;
using System.Linq;

namespace CodilityTasks
{
    public static class Lesson4
    {
        /// <summary>
        /// Count elements' occurrences. Only arrays with positive numbers.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="m">Max value in array.</param>
        /// <returns></returns>
        public static int[] CountingOccurrences(int[] array, int m)
        {
            int[] counts = new int[m + 1];
            foreach (int t in array)
            {
                counts[t] += 1;
            }
            return counts;
        }

        /// <summary>
        /// The goal is to check whether there is a swap operation which can be performed on these
        /// arrays in such a way that the sum of elements in array A equals the sum of elements in
        /// array B after the swap.By swap operation we mean picking one element from array A and
        /// one element from array B and exchanging them.
        /// </summary>
        /// <param name="arrayA"></param>
        /// <param name="arrayB"></param>
        /// <returns></returns>
        public static bool SwapSlowSolution(int[] arrayA, int[] arrayB)
        {
            if (arrayA.Length != arrayB.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayA));
            }

            int n = arrayA.Length;
            Int64 sumA = Sum(arrayA);
            Int64 sumB = Sum(arrayB);
            
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int change = arrayB[j] - arrayA[i];
                    sumA += change;
                    sumB -= change;
                    if (sumA == sumB)
                    {
                        return true;
                    }

                    sumA -= change;
                    sumB += change;
                }
            }
            return false;
        }

        /// <summary>
        /// The goal is to check whether there is a swap operation which can be performed on these
        /// arrays in such a way that the sum of elements in array A equals the sum of elements in
        /// array B after the swap.By swap operation we mean picking one element from array A and
        /// one element from array B and exchanging them.
        /// </summary>
        /// <param name="arrayA"></param>
        /// <param name="arrayB"></param>
        /// <param name="m">Max value in array.</param>
        /// <returns></returns>
        public static bool SwapFastSolution(int[] arrayA, int[] arrayB, int m)
        {
            if (arrayA.Length != arrayB.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayA));
            }

            int n = arrayA.Length;
            Int64 sumA = Sum(arrayA);
            Int64 sumB = Sum(arrayB);

            Int64 d = sumB - sumA;

            if (d%2 == 1)
            {
                return false;
            }

            d /= 2;
            int[] counts = CountingOccurrences(arrayA, m);

            for (int i = 0; i < n; i++)
            {
                if (0 <= arrayB[i] - d && arrayB[i] - d <= m && counts[arrayB[i] - d] > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static Int64 Sum(int[] array)
        {
            return array.Sum(x => (Int64) x);
        }
    }
}
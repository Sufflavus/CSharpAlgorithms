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

        public static int FrogRiverOne(int x, int[] array)
        {
            bool[] fellLeaves = new bool[x];
            int fellLeavesCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int leaveIndex = array[i] - 1;
                if (!fellLeaves[leaveIndex])
                {
                    fellLeaves[leaveIndex] = true;
                    fellLeavesCount++;
                    if (fellLeavesCount == x)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static int PermCheck(int[] array)
        {
            int n = array.Length;
            var sortedA = array.OrderBy(x => x).ToArray();

            if (sortedA[0] != 1)
            {
                return 0;
            }

            for (int i = 1; i < n; i++)
            {
                if (sortedA[i] != sortedA[i - 1] + 1)
                {
                    return 0;
                }
            }
            return 1;
        }

        /// <summary>
        /// given a non-empty zero-indexed array A of N integers, returns the minimal positive integer (greater than 0) 
        /// that does not occur in A
        /// </summary>
        /// <param name="array">N is an integer within the range [1..100,000];
        /// each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647].</param>
        /// <returns></returns>
        public static int MissingInteger(int[] array)
        {
            int n = array.Length;
            var sortedA = array.OrderBy(x => x).ToArray();

            if (n == 1)
            {
                return sortedA[0] == 1 ? 2 : 1;
            }

            if (sortedA[0] > 0 && sortedA[0] != 1)
            {
                return 1;
            }

            for (int i = 1; i < n; i++)
            {
                if (sortedA[i] == sortedA[i - 1] || sortedA[i] <= 0)
                {
                    continue;
                }

                if (sortedA[i] != sortedA[i - 1] + 1 && sortedA[i - 1] + 1 > 0)
                {
                    return sortedA[i - 1] + 1;
                }
            }

            return sortedA[n - 1] + 1 > 0 ? sortedA[n - 1] + 1 : 1;
        }

        private static Int64 Sum(int[] array)
        {
            return array.Sum(x => (Int64) x);
        }
    }
}
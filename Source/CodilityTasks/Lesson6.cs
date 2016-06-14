using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTasks
{
    public static class Lesson6
    {
        public static int[] SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int k = 0; k < n; k++)
            {
                int minimal = k;
                for (int j = k + 1; j < n; j++)
                {
                    if (array[j] < array[minimal])
                    {
                        minimal = j;
                    }
                }
                if (minimal != k)
                {
                    int temp = array[k];
                    array[k] = array[minimal];
                    array[minimal] = temp;
                }
            }
            return array;
        }

        /// <summary>
        /// elements are in the set {0, 1, ... , k }
        /// </summary>
        /// <param name="array"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] CountingSort(int[] array, int k)
        {
            int n = array.Length;
            int[] counts = new int[k + 1];
            for (int i = 0; i < n; i++)
            {
                counts[array[i]]++;
            }
            int p = 0;
            for (int i = 0; i < k + 1; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    array[p] = i;
                    p++;
                }
            }
            return array;
        }

        public static int DistinctCount(int[] array)
        {
            int n = array.Length;
            if (n == 0)
            {
                return 0;
            }

            var sortedArray = array.OrderBy(x => x).ToList();
            int result = 1;
            for (int k = 1; k < n; k++)
            {
                if (sortedArray[k] != sortedArray[k - 1])
                {
                    result++;
                }
            }
            return result;
        }

        /// <summary>
        /// given a zero-indexed array A consisting of N integers, returns 1 if there exists a triangular triplet 
        /// for this array and returns 0 otherwise
        /// </summary>
        /// <param name="array">N is an integer within the range [0..100,000];
        /// each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647]</param>
        /// <returns></returns>
        public static int Triangle(int[] array)
        {
            int n = array.Length;
            if (n < 3)
            {
                return 0;
            }
            int[] sortedArray = array.OrderBy(x => x).ToArray();
            for (int i = 0; i < n - 2; i++)
            {
                // Beware of overflow
                if (sortedArray[i] > 0 && sortedArray[i] > sortedArray[i + 2] - sortedArray[i + 1])
                {
                    return 1;
                }
            }
            return 0;
        }

        /// <summary>
        /// given a zero-indexed array A consisting of N integers, returns the number of distinct values in array A
        /// </summary>
        /// <param name="array">N is an integer within the range [0..100,000];
        /// each element of array A is an integer within the range[−1, 000, 000..1, 000, 000]</param>
        /// <returns></returns>
        public static int Distinct(int[] array)
        {
            int n = array.Length;
            if (n == 0)
            {
                return 0;
            }

            var sortedArray = array.OrderBy(x => x).ToArray();
            int result = 1;
            for (int k = 1; k < n; k++)
            {
                if (sortedArray[k] != sortedArray[k - 1])
                {
                    result++;
                }
            }
            return result;
        }

        /// <summary>
        /// given a non-empty zero-indexed array A, returns the value of the maximal product of any triplet
        /// </summary>
        /// <param name="array">N is an integer within the range [3..100,000];
        /// each element of array A is an integer within the range[−1, 000..1, 000]</param>
        /// <returns></returns>
        public static int MaxProductOfThree(int[] array)
        {
            int n = array.Length;
            if (n < 3)
            {
                return 0;
            }

            int[] sortedArray = array.OrderBy(x => x).ToArray();
            return Math.Max(sortedArray[n - 1] * sortedArray[n - 2] * sortedArray[n - 3],
                sortedArray[0] * sortedArray[1] * sortedArray[n - 1]);
        }
    }
}
using System;
using System.Linq;

namespace CodilityTasks
{
    public static class Lesson3
    {
        /// <summary>
        /// You are given an integer n. Count the total of 1 + 2 + ... + n.
        /// Slow solution — time complexity O(n2).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountTotalSlowSolution(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int result = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < i + 1; j++)
                {
                    result += 1;
                }
            }
            return result;
        }

        /// <summary>
        /// You are given an integer n. Count the total of 1 + 2 + ... + n.  
        /// Fast solution — time complexity O(n).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountTotalFastSolution(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int result = 0;
            for (var i = 0; i < n; i++)
            {
                result += (i + 1);
            }
            return result;
        }

        /// <summary>
        /// You are given an integer n. Count the total of 1 + 2 + ... + n.
        /// Model solution — time complexity O(1).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountTotalSuperFastSolution(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return n*(n + 1)/2;
        }

        /// <summary>
        /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants 
        /// to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
        /// Count the minimal number of jumps that the small frog must perform to reach its target.
        /// </summary>
        /// <param name="x">X, Y and D are integers within the range [1..1,000,000,000], X less_or_equal Y</param>
        /// <param name="y"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int FrogJmp(int x, int y, int d)
        {
            int distance = y - x;
            return distance % d == 0 ? distance / d : distance / d + 1;
        }

        public static int TapeEquilibrium(int[] array)
        {
            int n = array.Length;
            int[] prefixSums = PrefixSums(array);
            int minDiff = int.MaxValue;
            for (int i = 1; i < n; i++)
            {
                int leftSum = GetSum(prefixSums, 0, i - 1);
                int rightSum = GetSum(prefixSums, i, n - 1);
                int diff = Math.Abs(leftSum - rightSum);
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }
            return minDiff;
        }

        /// <summary>
        /// A zero-indexed array A consisting of N different integers is given. The array contains integers in the range 
        /// [1..(N + 1)], which means that exactly one element is missing.
        /// Your goal is to find that missing element.
        /// </summary>
        /// <param name="array">N is an integer within the range [0..100,000];
        /// the elements of A are all distinct;
        /// each element of array A is an integer within the range[1..(N + 1)].</param>
        /// <returns></returns>
        public static int PermMissingElem(int[] array)
        {
            var sortedA = array.OrderBy(x => x).ToArray();

            if (sortedA.Length == 0 || sortedA[0] != 1)
            {
                return 1;
            }

            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                if (sortedA[i - 1] + 1 != sortedA[i])
                {
                    return sortedA[i - 1] + 1;
                }
            }
            return n + 1;
        }

        private static int[] PrefixSums(int[] array)
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
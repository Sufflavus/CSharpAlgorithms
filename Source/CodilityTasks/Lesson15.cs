using System;
using System.Linq;

namespace CodilityTasks
{
    /// <summary>
    /// Caterpillar method
    /// </summary>
    public static class Lesson15
    {
        /// <summary>
        /// check whether a sequence contains a contiguous subsequence whose sum of elements equals s
        /// </summary>
        /// <returns></returns>
        public static bool CaterpillarMethod(int[] array, int s)
        {
            int n = array.Length;
            int front = 0;
            int total = 0;
            for (int back = 0; back < n; back++)
            {
                while (front < n && total + array[front] <= s)
                {
                    total += array[front];
                    front += 1;
                }
                if (total == s)
                {
                    return true;
                }
                total -= array[back];
            }
            return false;
        }

        /// <summary>
        /// You are given n sticks, sorted by length. The goal is
        /// to count the number of triangles that can be constructed using these sticks.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Triangles(int[] array)
        {
            int n = array.Length;
            int result = 0;
            for (int x = 0; x < n; x++)
            {
                int z = x + 2;
                for (int y = x + 1; y < n; y++)
                {
                    while (z < n && array[x] + array[y] > array[z])
                    {
                        z++;
                    }
                    result += z - y - 1;
                }
            }
            return result;
        }

        public static int AbsDistinct(int[] array)
        {
            int[] sortedArray = array.Select(x => Math.Abs(x))
                .OrderBy(x => x)
                .ToArray();

            int count = 1;
            for (int i = 1; i < sortedArray.Length; i++)
            {
                if (sortedArray[i - 1] != sortedArray[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
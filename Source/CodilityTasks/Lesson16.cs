using System.Collections.Generic;

namespace CodilityTasks
{
    public static class Lesson16
    {
        /// <summary>
        /// There are n > 0 canoeists with weights ordered enc.
        /// The goal is to seat them in the minimum number of double canoes whose displacement(the
        /// maximum load) equals k.You may assume that w[i] less than k.
        /// </summary>
        /// <param name="w"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int GreedyCanoeistB(int[] w, int k)
        {
            int canoes = 0;
            int j = 0;
            int i = w.Length - 1;
            while (i >= j)
            {
                if (w[i] + w[j] <= k)
                {
                    j++;
                }
                canoes++;
                i--;
            }
            return canoes;
        }

        public static int TieRopes(int k, int[] array)
        {
            int count = 0;
            int length = 0;

            for (var i = 0; i < array.Length; i++)
            {
                length += array[i];
                if (length >= k)
                {
                    count++;
                    length = 0;
                }
            }

            return count;
        }
    }
}
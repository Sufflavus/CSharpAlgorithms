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
    }
}
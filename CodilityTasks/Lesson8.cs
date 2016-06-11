using System;
using System.Linq;
using System.Threading;

namespace CodilityTasks
{
    public static class Lesson8
    {
        /// <summary>
        /// The leader of this sequence is the element whose value occurs more than n/2 times.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SlowFindLeader(int[] array)
        {
            int n = array.Length;
            int leader = -1;
            for (int k = 0; k < n; k++)
            {
                int candidate = array[k];
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (array[i] == candidate)
                    {
                        count++;
                    }
                }
                if (count > n/2)
                {
                    leader = candidate;
                }
            }
            return leader;
        }

        /// <summary>
        /// The leader of this sequence is the element whose value occurs more than n/2 times.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int FastFindLeader(int[] array)
        {
            int n = array.Length;
            if (n == 0)
            {
                return -1;
            }

            int leader = -1;
            int[] sortedArray = array.OrderBy(x => x).ToArray();
            int candidate = sortedArray[n/2];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sortedArray[i] == candidate)
                {
                    count++;
                }
            }
            if (count > n / 2)
            {
                leader = candidate;
            }
            return leader;
        }

        /// <summary>
        /// The leader of this sequence is the element whose value occurs more than n/2 times.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GoldenFindLeader(int[] array)
        {
            int n = array.Length;
            if (n == 0)
            {
                return -1;
            }

            int size = 0;
            int value = array[0];
            for (int k = 0; k < n; k++)
            {
                if (size == 0)
                {
                    size++;
                    value = array[k];
                }
                else
                {
                    if (value != array[k])
                    {
                        size--;
                    }
                    else
                    {
                        size++;
                    }
                }
            }

            int candidate = -1;
            if (size > 0)
            {
                candidate = value;
            }
            
            int leader = -1;
            int count = 0;
            
            for (int k = 0; k < n; k++)
            {
                if (array[k] == candidate)
                {
                    count++;
                }
            }
            if (count > n / 2)
            {
                leader = candidate;
            }
            return leader;
        }
    }
}
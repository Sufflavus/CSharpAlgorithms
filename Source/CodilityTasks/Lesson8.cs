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

        /// <summary>
        /// Find the index S such that the leaders of the sequences A[0], A[1], ..., A[S] and 
        /// A[S + 1], A[S + 2], ..., A[N - 1] are the same.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int EquiLeader(int[] array)
        {
            int n = array.Length;

            if (n < 2)
            {
                return 0;
            }

            int leader;
            int[] sortedArray = array.OrderBy(x => x).ToArray();
            int candidate = sortedArray[n / 2];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sortedArray[i] == candidate)
                {
                    count++;
                }
            }
            if (count > n/2)
            {
                leader = candidate;
            }
            else
            {
                return 0;
            }

            int leadersCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == leader)
                {
                    leadersCount++;
                }
            }
            
            int equiLeaders = 0;
            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == leader)
                {
                    leftSum++;
                }
                if (leftSum > (i + 1)/2 && leadersCount - leftSum > (n - i - 1)/2)
                {
                    equiLeaders++;
                }
            }

            return equiLeaders;
        }

        /// <summary>
        /// given a zero-indexed array A consisting of N integers, returns index of any element of array A 
        /// in which the dominator of A occurs. The function should return −1 if array A does not have a dominator.
        /// </summary>
        /// <param name="array">N is an integer within the range [0..100,000];
        /// each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647].</param>
        /// <returns>https://codility.com/demo/results/trainingZ76R43-3DJ/</returns>
        public static int Dominator(int[] array)
        {
            int n = array.Length;
            if (n == 0)
            {
                return -1;
            }

            int leader;
            int[] sortedArray = array.OrderBy(x => x).ToArray();
            int candidate = sortedArray[n / 2];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sortedArray[i] == candidate)
                {
                    count++;
                }
            }
            if (count > n/2)
            {
                leader = candidate;
            }
            else
            {
                return -1;
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] == leader)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
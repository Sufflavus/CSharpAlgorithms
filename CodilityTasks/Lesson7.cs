using System;

namespace CodilityTasks
{
    public static class Lesson7
    {
        /// <summary>
        /// You are given a zero-indexed array A consisting of n integers: a[0], a[1], ... , a[n−1].
        /// Array A represents a scenario in a grocery store, and contains only 0s and/or 1s:
        ///• 0 represents the action of a new person joining the line in the grocery store,
        ///• 1 represents the action of the person at the front of the queue being served and leaving
        /// the line.
        /// The goal is to count the minimum number of people who should have been in the line before
        /// the above scenario, so that the scenario is possible (it is not possible to serve a person if the
        /// line is empty).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GroceryStore(byte[] array)
        {
            int n = array.Length;
            int size = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    size++;
                }
                else
                {
                    size--;
                    result = Math.Max(result, -size);
                }
            }
            return result;
        }
    }
}
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
    }
}
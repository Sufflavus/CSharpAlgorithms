namespace CodilityTasks
{
    /// <summary>
    /// Dynamic programming
    /// </summary>
    public static class Lesson17
    {
        /// <summary>
        /// A small frog wants to get from position 0 to k (1 more_than k less_than 10 000). The frog can
        /// jump over any one of n fixed distances s[0], s[1], ... , s[n−1] (1 more_than si less_than k).
        /// The goal is to count the  number of different ways in which the frog can jump to position k.
        /// To avoid overflow, it is sufficient to return the result modulo q, where q is a given number.
        /// We assume that two patterns of jumps are different if, in one pattern, the frog visits
        /// a position which is not visited in the other pattern.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static int Frog(int[] s, int k, int q)
        {
            int n = s.Length;
            int[] dp = new int[k];
            for (int d = 0; d < k; d++)
            {
                dp[d] = 1;
            }
            for (int j = 1; j < k + 1; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (s[i] <= j)
                    {
                        dp[j] = (dp[j] + dp[j - s[i]])%q;
                    }
                }
            }
            return dp[k];
        }
    }
}
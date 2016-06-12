namespace CodilityTasks
{
    /// <summary>
    /// Binary search algorithm
    /// </summary>
    public static class Lesson14
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">sorted array</param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] array, int x)
        {
            int n = array.Length;
            int beg = 0;
            int end = n - 1;
            int result = -1;
            while (beg <= end)
            {
                int mid = (beg + end)/2;
                if (array[mid] <= x)
                {
                    beg = mid + 1;
                    result = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return result;
        }

        /// <summary>
        /// You are given n binary values x[0], x[1], ... , x[n−1], such that x[i] ∈ {0, 1}. This array
        /// represents holes in a roof(1 is a hole). You are also given k boards of the same size.The goal
        /// is to choose the optimal (minimal) size of the boards that allows all the holes to be covered
        /// by boards.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double Boards(double[] array, int k)
        {
            int n = array.Length;
            int beg = 0;
            int end = n;
            int result = -1;
            while (beg <= end)
            {
                int mid = (beg + end)/2;
                if (Check(array, mid) <= k)
                {
                    end = mid - 1;
                    result = mid;
                }
                else
                {
                    beg = mid + 1;
                }
            }
            return result;
        }

        private static int Check(double[] array, int k)
        {
            int n = array.Length;
            int boards = 0;
            int last = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 1 && last < i)
                {
                    boards++;
                    last = i + k - 1;
                }
            }
            return boards;
        }
    }
}
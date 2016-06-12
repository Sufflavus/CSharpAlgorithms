namespace CodilityTasks
{
    /// <summary>
    /// Arrays
    /// </summary>
    public static class Lesson2
    {
        public static int[] RevertArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n/2; i++)
            {
                int k = n - i - 1;
                int temp = array[i];
                array[i] = array[k];
                array[k] = temp;
            }
            return array;
        }

        /// <summary>
        /// A zero-indexed array A consisting of N integers is given. Rotation of the array means 
        /// that each element is shifted right by one index, and the last element of the array
        /// is also moved to the first place.
        /// </summary>
        /// <param name="array">each element of array A is an integer within the range [−1,000..1,000]</param>
        /// <param name="k">N and K are integers within the range [0..100]</param>
        /// <returns></returns>
        public static int[] RotateArray(int[] array, int k)
        {
            int n = array.Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int j = (i + k) % n;
                result[j] = array[i];
            }
            return result;
        }
    }
}

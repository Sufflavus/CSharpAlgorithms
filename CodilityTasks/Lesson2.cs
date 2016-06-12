using System.Linq;

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

        /// <summary>
        /// A non-empty zero-indexed array A consisting of N integers is given. The array contains an odd number 
        /// of elements, and each element of the array can be paired with another element that has the same value, 
        /// except for one element that is left unpaired.
        /// </summary>
        /// <param name="array">N is an odd integer within the range [1..1,000,000]
        /// each element of array A is an integer within the range [1..1,000,000,000];
        /// all but one of the values in A occur an even number of times.</param>
        /// <returns></returns>
        public static int OddOccurrencesInArray(int[] array)
        {
            var sortedArray = array.OrderBy(x => x).ToArray();
            int currentNum = sortedArray[0];
            int sum = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (sortedArray[i] == currentNum)
                {
                    sum++;
                }
                else
                {
                    if (sum%2 == 1)
                    {
                        return currentNum;
                    }
                    currentNum = sortedArray[i];
                    sum = 1;
                }
            }
            return currentNum;
        }
    }
}

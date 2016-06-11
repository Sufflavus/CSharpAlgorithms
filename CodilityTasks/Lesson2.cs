namespace CodilityTasks
{
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
    }
}

namespace AlgorithmsLibrary
{
    public class Summ
    {
        public int DoSumm(int a, int b)
        {
            int c = a;
            for (int i = 1; i <= b; i++)
            {
                c = a + i;
            }
            return c;
        }
    }
}
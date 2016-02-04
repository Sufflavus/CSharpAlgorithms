namespace AlgorithmsLibrary
{
    public class Multiplication
    {
        public static int DoMultiplication(int a, int b)
        {
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c = c + a;
            }
            return c;
        }
    }
}
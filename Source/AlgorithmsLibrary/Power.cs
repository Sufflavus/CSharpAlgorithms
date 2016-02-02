namespace AlgorithmsLibrary
{
    public class Power
    {
        public static int Power2(int a, int n)
        {
            int b = 1;
            for (int i = n; i > 0; i--)
            {
                b = b * a;
            }
            return b;
        }

        public static int Power1(int a, int n)
        {
            int b = 1;
            for (int i = 1; i <= n; i++)
            {
                b = b * a;
            }
            return b;
        }

    }
}
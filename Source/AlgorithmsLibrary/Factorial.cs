namespace AlgorithmsLibrary
{
    public class Factorial
    {
        public int Method1(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

       public int Method2(int n)
        {
            var factorials = new int[n + 1];
            factorials[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }
            return factorials[n];
        }

        public int Method3(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return Method3(n - 1) * n;
        }
    }
}
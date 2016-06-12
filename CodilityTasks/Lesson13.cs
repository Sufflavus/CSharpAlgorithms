namespace CodilityTasks
{
    /// <summary>
    /// Fibonacci numbers
    /// </summary>
    public static class Lesson13
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int FibonacciDynamic(int n)
        {
            int[] fib = new int[n + 2];
            fib[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }
    }
}
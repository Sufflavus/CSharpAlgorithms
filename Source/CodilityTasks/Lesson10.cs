using System;

namespace CodilityTasks
{
    public static class Lesson10
    {
        public static int DivisorsCount(int n)
        {
            int i = 1;
            int result = 0;
            while (i*i < n)
            {
                if (n%i == 0)
                {
                    result += 2;
                }
                i++;
            }
            if (i*i == n)
            {
                result++;
            }
            return result;
        }

        public static bool IsPrime(int n)
        {
            int i = 2;
            while (i*i <= n)
            {
                if (n%i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }

        /// <summary>
        /// Consider n coins aligned in a row. Each coin is showing heads at the beginning.
        /// Then, n people turn over corresponding coins as follows. Person i reverses coins with numbers
        /// that are multiples of i.That is, person i flips coins i, 2*i, 3*i, ... until no more appropriate
        /// coins remain.The goal is to count the number of coins showing tails. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ReverseCoins(int n)
        {
            int result = 0;
            int[] coins = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                int k = i;
                while (k <= n)
                {
                    coins[k] = (coins[k] + 1)%2;
                    k += i;
                }
                result += coins[i];
            }
            return result;
        }

        public static int MinPerimeterRectangle(int n)
        {
            int minPerimeter = int.MaxValue;

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    minPerimeter = Math.Min(minPerimeter, 2 * (n / i + i));
                }
            }

            return minPerimeter;
        }
    }
}
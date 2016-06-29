using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace CodilityTasks
{
    public static class Lesson11
    {
        /// <summary>
        /// The Sieve of Eratosthenes is a very simple and popular technique for finding all the prime
        /// numbers in the range from 2 to a given number n.
        /// Initially, we have the set of all the numbers {2, 3,...,n}. At each step we choose the
        /// smallest number in the set and remove all its multiples.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool[] Sieve(int n)
        {
            bool[] sieve = new bool[n + 1];
            for (int j = 0; j < sieve.Length; j++)
            {
                sieve[j] = true;
            }

            sieve[0] = false;
            sieve[1] = false;
            int i = 2;
            while (i*i <= n)
            {
                if (sieve[i])
                {
                    int k = i*i;
                    while (k <= n)
                    {
                        sieve[k] = false;
                        k += i;
                    }
                }
                i++;
            }
            return sieve;
        }

        public static int[] Factorization(int x)
        {
            int[] f = ArrayF(x);
            var primeFactors = new List<int>();
            while (f[x] > 0)
            {
                primeFactors.Add(f[x]);
                x /= f[x];
            }
            primeFactors.Add(x);
            return primeFactors.ToArray();
        }

        public static int[] CountSemiprimes(int n, int[] p, int[] q)
        {
            bool[] sieve = Sieve(n);
            var semiprimes = new List<int>();

            var i = 2;
            while (i * i <= n)
            {
                if (sieve[i])
                {
                    for (int j = i*i; j < n + 1; j++)
                    {
                        if (j%i == 0 && sieve[j / i])
                        {
                            semiprimes.Add(j);
                        }
                    }
                }
                i++;
            }

            int[] counts = new int[n + 1];

            counts[0] = 0;
            counts[1] = 0;
            counts[2] = 0;
            counts[3] = 0;
            counts[4] = 1;

            int m = 1;

            for (int j = 5; j < n + 1; j++)
            {
                if (semiprimes.Contains(j))
                {
                    m++;
                }
                counts[j] = m;
            }

            var result = new List<int>();

            for (int j = 0; j < q.Length; j++)
            {
                result.Add(counts[q[j]] - counts[p[j] - 1]);
            }

            return result.ToArray();
        }
        
        private static int[] ArrayF(int n)
        {
            int[] f = new int[n + 1];
            int i = 2;
            while (i * i <= n)
            {
                if (f[i] ==0)
                {
                    int k = i * i;
                    while (k <= n)
                    {
                        if (f[k] == 0)
                        {
                            f[k] = i;
                        }
                        k += i;
                    }
                }
                i++;
            }
            return f;
        }
    }
}
using System.Runtime.InteropServices.ComTypes;

namespace CodilityTasks
{
    public static class Lesson12
    {
        /// <summary>
        ///  computing the greatest common divisor (gcd) of two positive integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Gcd1(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            if (a > b)
            {
                return Gcd1(a - b, b);
            }

            return Gcd1(a, b - a);
        }

        /// <summary>
        ///  computing the greatest common divisor (gcd) of two positive integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Gcd2(int a, int b)
        {
            if (a%b == 0)
            {
                return b;
            }

            return Gcd2(b, a%b);
        }

        /// <summary>
        ///  computing the greatest common divisor (gcd) of two positive integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Gcd3(int a, int b, int res)
        {
            if (a == b)
            {
                return res*a;
            }
            if (a%2 == 0 && b%2 == 0)
            {
                Gcd3(a/2, b/2, 2*res);
            }
            if (a%2 == 0)
            {
                Gcd3(a/2, b, res);
            }
            if (b%2 == 0)
            {
                Gcd3(a, b/2, res);
            }
            if (a > b)
            {
                Gcd3(a - b, b, res);
            }

            return Gcd3(a, b - a, res);
        }
    }
}
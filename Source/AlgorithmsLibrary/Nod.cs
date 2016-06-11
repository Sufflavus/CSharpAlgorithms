namespace AlgorithmsLibrary
{
    public class Nod
    {
        public static void CalculateNod5(int a, int b)
        {
            int x;
            int y;

            var m = a;
            var n = b;
            var p = 1;
            var q = 0;
            var r = 0;
            var s = 1;

            int k;

            while (!((m == 0) || n == 0))
            {
                if (m >= n)
                {
                    m = m%n;
                    p = p - r;
                    q = q - s;
                }
                else
                {
                    n = n%m;
                    r = r - p;
                    s = s - q;
                }
            }

            if (m == 0)
            {
                k = n;
                x = r;
                y = s;
            }
            else // n=0
            {
                k = m;
                x = p;
                y = q;
            }
        }


        public static void CalculateNod4(int a, int b)
        {
            int x;
            int y;

            var m = a;
            var n = b;
            var p = 1;
            var q = 0;
            var r = 0;
            var s = 1;

            int k;

            while (!((m == 0) || n == 0))
            {
                if (m >= n)
                {
                    m = m - n;
                    p = p - r;
                    q = q - s;
                }
                else
                {
                    n = n - m;
                    r = r - p;
                    s = s - q;
                }
            }

            if (m == 0)
            {
                k = n;
                x = r;
                y = s;
            }
            else // n=0
            {
                k = m;
                x = p;
                y = q;
            }
        }

        public static double CalculateNod3(int a, int b)
        {
            if (a <= 0)
            {
                return b;
            }

            if (b <= 0)
            {
                return a;
            }

            var m = a;
            var n = b;
            int k;

            while (!((m == 0) || n == 0))
            {
                if (m >= n)
                {
                    m = m%n;
                }
                else
                {
                    n = n%m;
                }
            }

            if (m == 0)
            {
                k = n;
            }
            else // n=0
            {
                k = m;
            }

            return k;
        }

        public static double CalculateNod2(int a, int b)
        {
            if (a <= 0)
            {
                return b;
            }

            if (b <= 0)
            {
                return a;
            }

            var m = a;
            var n = b;
            int k;

            while (!((m == 0) || n == 0))
            {
                if (m >= n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            if (m == 0)
            {
                k = n;
            }
            else // n=0
            {
                k = m;
            }

            return k;
        }

        public static double CalculateNod1(int a, int b)
        {
            if (a <= 0)
            {
                return b;
            }

            if (b <= 0)
            {
                return a;
            }

            var k = a < b ? a : b; // k=min{a, b}
            while (!((a%k == 0) && (b%k == 0)))
            {
                k--;
            }
            return k;
        }
    }
}
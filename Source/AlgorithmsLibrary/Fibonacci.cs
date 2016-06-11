namespace AlgorithmsLibrary
{
    public class Fibonacci
    {
        public static int GetNthItem1(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            var elements = new int[n + 1];
            elements[0] = 0;
            elements[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                elements[i] = elements[i - 1] + elements[i - 2];
            }

            return elements[n];
        }

        public static int GetNthItem2(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            var element1 = 0;
            var element2 = 1;
            var result = 1;

            for (var i = 2; i <= n; i++)
            {
                result = element1 + element2;
                element1 = element2;
                element2 = result;
            }

            return result;
        }
    }
}
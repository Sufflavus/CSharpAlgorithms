namespace AlgorithmsLibrary
{
    public class Sequence
    {
        /// <summary>
        /// Get summ of sequence 1/0!+1/1!+...+1/n!
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double GetSumm1(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            var elements = new double[n + 1];
            elements[0] = 1;

            var factorials = new int[n + 1];
            factorials[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                factorials[i] = factorials[i - 1] * i;
                elements[i] = elements[i - 1] + 1 / (double)factorials[i];
            }

            return elements[n];
        }

        /// <summary>
        /// Get summ of sequence 1/0!+1/1!+...+1/n!
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double GetSumm2(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            double prevElement = 1;
            int factorial = 1;
            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                result = prevElement + 1 / (double)factorial;
                prevElement = result;
            }

            return result;
        }
    }
}
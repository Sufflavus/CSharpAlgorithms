using System.Text;

namespace CodilityTasks
{
    /// <summary>
    /// Iterations
    /// </summary>
    public static class Lesson1
    {
        /// <summary>
        /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros 
        /// that is surrounded by ones at both ends in the binary representation of N.
        /// </summary>
        /// <param name="n">N is an integer within the range [1..2,147,483,647].</param>
        /// <returns></returns>
        public static int SlowBinaryGap(int n)
        {
            string binary = ConvertToBinary(n);
            int max = 0;
            int currentGap = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1' && currentGap > 0)
                {
                    if (currentGap > max)
                    {
                        max = currentGap;
                    }
                    currentGap = 0;
                }
                else if (binary[i] == '0')
                {
                    if (currentGap == 0 && i > 0 && binary[i - 1] == '1' || currentGap > 0)
                    {
                        currentGap++;
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros 
        /// that is surrounded by ones at both ends in the binary representation of N.
        /// </summary>
        /// <param name="n">N is an integer within the range [1..2,147,483,647].</param>
        /// <returns></returns>
        public static int FastBinaryGap(int n)
        {
            int maxGap = 0;
            int currentGap = 0;
            int gapStartIndex = -1;
            int i = 0;
            while (n >= 1)
            {
                int currentNumber = n%2;
                n /= 2;
                if (currentNumber == 1)
                {
                    gapStartIndex = i;
                    if (currentGap > 0)
                    {
                        if (currentGap > maxGap)
                        {
                            maxGap = currentGap;
                        }
                        currentGap = 0;
                    }
                }
                else
                {
                    if (currentGap == 0 && i > 0 && gapStartIndex == i - 1 || currentGap > 0)
                    {
                        currentGap++;
                    }
                }
                i++;
            }
            return maxGap;
        }

        private static string ConvertToBinary(int N)
        {
            var sb = new StringBuilder();
            while (N >= 1)
            {
                sb.Insert(0, N%2);
                N /= 2;
            }
            return sb.ToString();
        }
    }
}
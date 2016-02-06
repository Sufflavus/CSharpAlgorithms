using AlgorithmsLibrary.ResultData;

namespace AlgorithmsLibrary
{
    public class Division
    {
        public DivisionResult DoDivision(int a, int d)
        {
            int r = a;
            int q = 0;
            while (r >= d)
            {
                r = r - d;
                q++;
            }
            return new DivisionResult { Div = q, Mod = r };
        }
    }
}
namespace AlgorithmsLibrary
{
    public class QuickFind
    {
        public QuickFind(int capacity)
        {
            Result = new int[capacity];
            for (var i = 0; i < capacity; i++)
            {
                Result[i] = i;
            }
        }

        public int[] Result { get; }

        public bool IsConnected(int p, int q)
        {
            return Result[p] == Result[q];
        }

        public void Union(int p, int q)
        {
            var pValue = Result[p];
            var qValue = Result[q];

            for (var i = 0; i < Result.Length; i++)
            {
                if (Result[i] == pValue)
                {
                    Result[i] = qValue;
                }
            }
        }
    }
}
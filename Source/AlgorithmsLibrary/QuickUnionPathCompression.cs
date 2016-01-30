namespace AlgorithmsLibrary
{
    public class QuickUnionPathCompression
    {
        public QuickUnionPathCompression(int capacity)
        {
            Result = new int[capacity];
            for (var i = 0; i < capacity; i++)
            {
                Result[i] = i;
            }
        }

        public int[] Result { get; }

        private int GetRoot(int index)
        {
            while (index != Result[index])
            {
                Result[index] = Result[Result[index]];
                index = Result[index];
            }
            return index;
        }

        public bool IsConnected(int p, int q)
        {
            return GetRoot(p) == GetRoot(q);
        }

        public void Union(int p, int q)
        {
            var pRoot = GetRoot(p);
            var qRoot = GetRoot(q);

            Result[pRoot] = qRoot;
        }
    }
}
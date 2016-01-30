namespace AlgorithmsLibrary
{
    public class QuickUnionWeighted
    {
        private readonly int[] _sizes;

        public QuickUnionWeighted(int capacity)
        {
            Result = new int[capacity];
            _sizes = new int[capacity];
            for (var i = 0; i < capacity; i++)
            {
                Result[i] = i;
                _sizes[i] = 1;
            }
        }

        public int[] Result { get; }

        private int GetRoot(int index)
        {
            while (index != Result[index])
            {
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

            if (pRoot == qRoot)
            {
                return;
            }

            if (_sizes[pRoot] < _sizes[qRoot])
            {
                Result[pRoot] = qRoot;
                _sizes[qRoot] += _sizes[pRoot];
            }
            else
            {
                Result[qRoot] = pRoot;
                _sizes[pRoot] += _sizes[qRoot];
            }
        }
    }
}
namespace AlgorithmsLibrary
{
    public class QuickFind
    {
        private readonly int[] _source;

        public QuickFind(int capacity)
        {
            _source = new int[capacity];
            for (var i = 0; i < capacity; i++)
            {
                _source[i] = i;
            }
        }

        public bool IsConnected(int p, int q)
        {
            return _source[p] == _source[q];
        }

        public void Union(int p, int q)
        {
            var pValue = _source[p];
            var qValue = _source[q];

            for (var i = 0; i < _source.Length; i++)
            {
                if (_source[i] == pValue)
                {
                    _source[i] = qValue;
                }
            }
        }
    }
}
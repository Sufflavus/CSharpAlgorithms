namespace AlgorithmsLibrary.Stack
{
    public class FixedCapacityStackOfStrings
    {
        private readonly string[] _stack;
        private int _n;

        public FixedCapacityStackOfStrings(int capacity)
        {
            _stack = new string[capacity];
        }

        public void Push(string item)
        {
            _stack[_n++] = item;
        }

        public string Pop()
        {
            return _stack[--_n];

            /*
            // avoid loitering
            string item = _stack[--_n];
            _stack[_n] = null;
            return item;*/
        }

        public bool IsEmpty()
        {
            return _n == 0;
        }
    }
}
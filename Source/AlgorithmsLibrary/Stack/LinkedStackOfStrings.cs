namespace AlgorithmsLibrary.Stack
{
    public class LinkedStackOfStrings
    {
        private Node _first;

        public void Push(string item)
        {
            var oldFirst = _first;
            _first = new Node
            {
                Item = item,
                Next = oldFirst
            };
        }

        public string Pop()
        {
            var item = _first.Item;
            _first = _first.Next;
            return item;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        private class Node
        {
            public string Item { get; set; }
            public Node Next { get; set; }
        }
    }
}
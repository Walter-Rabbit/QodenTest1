namespace task1
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; private set; }

        public ListNode()
        {
            Value = 0;
            Next = null;
        }

        public ListNode(int value)
        {
            Value = value;
            Next = null;
        }

        public void Insert(int value)
        {
            var node = this;

            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = new ListNode(value);
        }
    }
}
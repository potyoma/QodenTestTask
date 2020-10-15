namespace task1
{
    public class ListNode
    {
        internal int Value { get; set; }
        internal ListNode Next { get;set; }

        public ListNode()
        {
            Next = null;
        }

        public void Insert(int newValue)
        {
            Value = newValue;
        }
    }
}

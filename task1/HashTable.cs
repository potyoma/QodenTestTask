namespace task1
{
    public class HashTable
    {
        public ListNode[] Values;
        public int Length { get; private set; }

        public HashTable(int length)
        {
            Length = length;
            Values = new ListNode[Length];
        }

        public void Insert(int newValue)
        {
            var hashed = newValue % Length;
            var newNode = Values[hashed];

            if (newNode != null)
            {
                while (newNode.Next != null)
                {
                    newNode = newNode.Next;
                }

                newNode.Next = new ListNode();
                newNode.Next.Insert(newValue);
                
                return;
            }

            Values[hashed] = new ListNode();
            Values[hashed].Insert(newValue);
        }
    }
}

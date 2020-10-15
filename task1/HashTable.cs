using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public class HashTable
    {
        public ListNode[] Values;
        public int N;

        public HashTable(int n)
        {
            N = n;
            Values = new ListNode[N];
        }

        public void Insert(int newValue)
        {
            ListNode newNode = Values[GetHash(newValue)];

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

            Values[GetHash(newValue)] = new ListNode();
            Values[GetHash(newValue)].Insert(newValue);
        }

        private int GetHash(int number)
        {
            return number % N;
        }
    }
}

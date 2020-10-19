using System;
using static System.Console;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(ReadLine());
            string[] numbers = ReadLine().Split();

            var hashTable = new HashTable(n);

            foreach (var number in numbers)
            {
                hashTable.Insert(Int32.Parse(number));
            }

            for (int i = 0; i < n; i++)
            {
                Write($"{i}: ");
                
                var node = hashTable.Values[i];
                while (node?.Next != null)
                {
                    var current = node.Value;
                    Write($"{current} ");
                    node = node.Next;
                }
                if (node != null)
                {
                    WriteLine($"{node.Value}");
                    continue;
                }
                WriteLine();
            }
        }
    }
}

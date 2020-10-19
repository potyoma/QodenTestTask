using System.Linq;
using System.Collections.Immutable;
using System;
using static System.Console;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = ReadLine().Split();
            int maxLength = text
                .Max(t => t.Length);

            var query = text
                .ToImmutableSortedSet()
                .Select(c => new
                {
                    Word = c,
                    Count = (int)Math.Ceiling((double)text.Count(e => e == c) / text.Length * 10)
                })
                .OrderBy(c => c.Count);

            foreach (var pair in query)
            {
                char[] underlines = new char[maxLength - pair.Word.Length];
                Array.Fill(underlines, '_');
                char[] dots = new char[pair.Count];
                Array.Fill(dots, '.');
                WriteLine($"{new string(underlines)}{pair.Word} {new string(dots)}");
            }
        }
    }
}

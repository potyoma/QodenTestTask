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
                    Count = (double)text.Count(e => e == c) / text.Length
                })
                .OrderBy(c => c.Count);

            var mostCommon = query
                .Max(e => e.Count);

            foreach (var pair in query)
            {
                var frequency = (int)Math.Round(pair.Count * 10 / mostCommon, 0);

                char[] underlines = new char[maxLength - pair.Word.Length];
                Array.Fill(underlines, '_');
                char[] dots = new char[frequency];
                Array.Fill(dots, '.');
                WriteLine($"{new string(underlines)}{pair.Word} {new string(dots)}");
            }
        }
    }
}

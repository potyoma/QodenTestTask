using System.Linq;
using System.ComponentModel.DataAnnotations;
using static System.Console;
using System.Collections.Immutable;
using System;

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
                    Count = Math.Round(((double)text.Count(e => e == c) / text.Length) * 10.0, 0)
                })
                .OrderBy(c => c.Count);

            foreach (var pair in query)
            {
                char[] underlines = new char[maxLength - pair.Word.Length];
                Array.Fill(underlines, '_');
                char[] dots = new char[(int)pair.Count];
                Array.Fill(dots, '.');
                WriteLine($"{new string(underlines)}{pair.Word} {new string(dots)}");
            }
        }
    }
}

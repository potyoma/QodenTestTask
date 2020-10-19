using System;
using System.Collections.Generic;
using static System.Console;

namespace task3 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            string[] line = ReadLine().Split();
            Stack<int> numbers = new Stack<int>();

            foreach (var item in line) 
            {
                bool success = Int32.TryParse(item, out int temp);

                if (success)
                {
                    numbers.Push(temp);
                    continue;
                }

                int second = numbers.Pop();

                numbers.Push(
                    MakeAction(numbers.Pop(), second, item));
            }

            WriteLine(numbers.Pop());
        }

        static int MakeAction(int number1, int number2, string digit) 
        {
            return digit switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" => number1 / number2,
                _ => throw new ArithmeticException("Operation is not valid!")
            };
        }
    }
}
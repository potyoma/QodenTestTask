using System;
using static System.Console;

namespace task3 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            string[] line = "5 10 + 10 *".Split();
            int number = Int32.Parse(line[0]);
            int numberSecond = 0;

            foreach (var item in line) 
            {
                int temp;
                bool success = Int32.TryParse(item, out temp);

                if (success)
                {
                    numberSecond = temp;
                    continue;
                }

                number = MakeAction(number, numberSecond, item);
            }

            WriteLine(number);
        }

        static int MakeAction(int number1, int number2, string digit) 
        {
            int result;

            switch (digit)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("Operation is not valid!");
            }

            return result;
        }
    }
}
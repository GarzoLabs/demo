using System;
using System.Collections.Generic;

namespace ListDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            var level = 0;
            while (level < 100) {
                var lastNumber = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previousNumber = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(lastNumber + previousNumber);

                level++;
            }

            foreach (var number in fibonacciNumbers)
            {
                Console.Write($"{number}");
            }
        }
    }
}

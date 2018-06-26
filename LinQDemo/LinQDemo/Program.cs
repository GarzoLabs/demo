using System;
using System.Linq;

namespace LinQDemo
{
    class LinkQExample {
        public static void queryIntNumbers() {
            // 1. Data source
            int[] numbers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            // 2. Query Creation
            var queryResult =
                from number in numbers
                where (number % 2) == 0
                select number;

            // 3. Query Execution
            foreach (int number in queryResult)//IEnumerable<int>
            {
                Console.Write($"{number}");
            }



            // 4. Convert Result in Array
            Console.WriteLine("convert query's result in an Array");
            var arrayOfNumbers = queryResult.ToArray();
            foreach (int number in arrayOfNumbers) // This is in Array
            {
                Console.Write($"{number}");
            }

            // 5. Convert Result in a List
            Console.WriteLine("convert query's result in an List");
            var listOfNumbers = queryResult.ToList();
            foreach (int number in listOfNumbers) // This is in Array
            {
                Console.Write($"{number}");
            }

            Console.WriteLine("End if convertions");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkQExample.queryIntNumbers();
        }
    }
}

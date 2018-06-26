using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<string> { "cat", "dog", "dinosaour", "tigger" };
            animals.Add("lion");
            foreach (var animal in animals) {
                Console.WriteLine($"Hello {animal.ToUpper()}");
            }

            Console.WriteLine($"animals[i] = {animals[1]}");
           
            var indexOfLion = animals.IndexOf("lion");
            if (indexOfLion < 0) {
                Console.WriteLine("Cannot find \"lion\" in the List!");
            }
            else
            {
                Console.WriteLine($"indexOfLion = {indexOfLion}");
            }

            animals.Sort();
            Console.WriteLine("List anter sort");
            foreach (var animal in animals){
                Console.WriteLine($"{animal}");
            }

            animals.Reverse();
            Console.WriteLine("List anter reverse");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal}");
            }

            Console.WriteLine($"animals has {animals.Count} elements");

        }
    }
}

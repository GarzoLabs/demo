using System;
using System.Linq;

namespace LinkQ_Tutorial { 
    class Program
    {
        static void Main(string[] args)
        {
            string[] group1 = { "Hector", "Pedro", "Samir", "Amir" };
            string[] group2 = { "Jacquelinne", "Pedro", "Sebastian", "Hector" };

            var concatGroup = group1.Union(group2);
            foreach (var item in concatGroup)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------------");

            var concatGroup2 = group1.Intersect(group2);
            foreach (var item in concatGroup2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
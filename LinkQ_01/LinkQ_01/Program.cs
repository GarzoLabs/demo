using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkQ_01
{
    class Book {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>()
            {
                "Red","Books","Car","Computer","Mobile","Program",
                "Driver","Window","Key","Home", "Pen","Right","Play",
                "Clic","Language","Rule","Peace","Word","File"
            };

            //no linkQ syntax
            /*List<string> Result = new List<string>();

            for (int i = 0; i < Names.Count; i++) {
                if (Names[i].Length > 3)
                {
                    Result.Add(Names[i]);
                }
            }*/

            //LinkQ query syntax #1
            //var Result = from item in Names where item.Length > 3 select item;


            //LinkQ Non-Query Syntax #1
            //var Result = Names.Where(item => item.Length > 3);

            //LinkQ query syntax #2
            /*var Result = from items in Names
                         where items.StartsWith("P") && items.Length == 3
                         select items;*/

            //LinkQ Non-Query Syntax #2

            Book[] books = {
               /* 
                new Book {Id =1, Title="C# Programming",Author="Kamal Younes"},
                new Book {Id =2, Title="Java Tutorials",Author="Ahmed Rochdi"},
                new Book {Id =3, Title="Perl for Beginners",Author="Ismael Rachid"},
                new Book { Id=4, Title="Android Programming",Author="Ayman Jalal"}
               */

                /*
                new Book {Id =6, Title="C# Programming",Author="Kamal Younes"},
                new Book {Id =7, Title="Java Tutorials",Author="Ahmed Rochdi"},
                new Book {Id =4, Title="Perl for Beginners",Author="Ismael Rachid"},
                new Book { Id=7, Title="Android Programming",Author="Ayman Jalal"}
                */
                new Book {Id =1, Title="C# Programming",Author="Kamal Younes"},
                new Book {Id =2, Title="Java Tutorials",Author="Ahmed Rochdi"},
                new Book {Id =3, Title="Perl for Beginners",Author="Ismael Rachid"},
                new Book { Id=4, Title="C#",Author="Khalid ESSAADANI"},
                new Book { Id=5, Title="C++",Author="Hamid MAKBOUL"},
                new Book { Id=6, Title="PHP",Author="Said HAMRI"},
                new Book { Id=7, Title="Ruby",Author="Ahmed Rochdi"}
            };

            //Query Syntax over list of objects
            /*var List = from item 
                       in books
                       orderby item.Id ascending, item.Title descending
                       select item;*/

            //Non-Query Syntax / Fluent Syntax #3
            //var List = books.OrderByDescending(item => item.Id);

            //Non-Query Syntax / Fluent Syntax #4
            //var List = books.OrderBy(item => item.Id).ThenByDescending(item => item.Title);



            //linkQ with group by return a list of list
            /*var List = from item 
                       in books
                       group item by item.Author;*/

            //Non-Query Syntax
            var List = books.GroupBy(item =>item.Author);

            foreach (var item in List)
            {
                Console.WriteLine("Author: " + item.Key);
                Console.WriteLine("-----------------------------");
                foreach (var book in item)
                {
                    Console.WriteLine("Id={0}\nTitle={1}\n", book.Id, book.Title, book.Author);
                }
                /*Console.WriteLine("Id={0}\nTitle={1}\nAuthor={2}", item.Id, item.Title, item.Author);
                Console.WriteLine("-----------------------------");*/
            }

            //var Result = Names.Where(item => item.Contains("P")).Take(2);

            /*foreach (var item in Result)
            {
                Console.WriteLine(item);
            }*/

            //Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace IEnumerableDemo
{
    public class Point
    {
        public Double x { get; set;}
        public Double y { get; set; }
        public Point(Double x, Double y) {
            this.x = x;
            this.y = y;
        }

        public void ShowInfo() {
            Console.WriteLine($"x = {this.x}, y= {this.y}");
        }
    }

    class Program
    {
        static IEnumerable<string> ReadFrom(string fileName) {
            var reader = File.OpenText(fileName);
            string eachLine;
            while ((eachLine = reader.ReadLine()) != null)
            {
                yield return eachLine;
            }
        }

        static void Main(string[] args)
        {
            var lines = ReadFrom("textFile.txt");
            var points = new List<Point>();
            foreach (var line in lines)
            {
                var numbers = line.Split(new[] { ", " }, StringSplitOptions.None);
                var x = Convert.ToDouble(numbers[0]);
                var y = Convert.ToDouble(numbers[1]);

                var newPoint = new Point(x, y);
                points.Add(newPoint);
            }

            Console.WriteLine("List of points..");
            foreach (var point in points)
            {
                point.ShowInfo();
            }
        }
    }
}

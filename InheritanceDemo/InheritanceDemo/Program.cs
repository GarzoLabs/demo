using System;

namespace InheritanceDemo
{
    public class Vehicle {
        public string Color;
        protected int Miles;
        protected int Year;

        //virtual mean that can be override
        public virtual void Greet() {
            Console.WriteLine("Hello, this is a Vehicle");
        }
    }

    public class Bus : Vehicle {
        public override void Greet() {
            base.Greet();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

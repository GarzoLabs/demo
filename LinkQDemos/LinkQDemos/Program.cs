using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Domain Specific Languages

            //imperative style
            for(int i=0; i < 13; i++)
            {
                int copy = i;
                int sum = 0;

                do{
                    sum += (int)Math.Pow((double)copy % 10, 3);
                    copy = copy / 10;
                } while(copy != 0);

                if(sum==i)
                    Console.WriteLine(i);
            }

            //Embbeded DSL
            /*Enumerable.Range(1, 1000)
                .Where(n => n.Digits().Cube().Sum() == n)
                .ToList()
                .ForEach(Console.WriteLine);*/
        }
    }
}

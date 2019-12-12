using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>();
            var list2 = new List<string>();
            list2.AddRange(new List<string>());

            var car = new Car<Farkop>(new Farkop());

            car.PrintFarkop();
            Console.WriteLine("=============");
        }
    }
}

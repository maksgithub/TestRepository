using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Farkop
    {
        public string Name { get; set; }
        public int Size { get; set; }
    }
    class Car<T> : Transport 
        where T : Farkop
    {
        private readonly T _farkop;

        public Car(T farkop)
        {
            _farkop = farkop;
        }

        public void PrintFarkop()
        {
            Console.WriteLine($"name = {_farkop.Name}, size = {_farkop.Size}");
        }
    }

    internal class Transport
    {
    }
}

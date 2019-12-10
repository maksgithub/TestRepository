
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var s in args)
            {
                Console.WriteLine(s);
            }
        }
    }
}

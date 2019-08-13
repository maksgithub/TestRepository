using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mars homework!");
            Console.WriteLine("Enter edge for Fibonacci sequence: ");
            int length = Convert.ToInt32(Console.ReadLine());
            FibonacciSequence fibonacci = new FibonacciSequence(length);
            fibonacci.FibonacciStart(length);
            Console.ReadKey();
        }
    }
}

﻿using System;
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
            List<int> fibSec = fibonacci.CreateSequence(length);
            Console.WriteLine("- - - - - - - - - - ");
            fibonacci.FibonacciPrint(fibSec,length);
            Console.WriteLine("- - - - - - - - - - ");
            Console.WriteLine("Fibonacci sequence sum: "+ fibonacci.FibonacciSequenceSum(fibSec));
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PListSerializer.Core;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Deserializer();
            var t = d.Deserialize<Class1>(null);
            Console.ReadKey();
        }
    }

    internal class Class1
    {
    }
}
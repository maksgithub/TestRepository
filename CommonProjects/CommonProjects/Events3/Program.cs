using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events3
{
    class Program
    {
                
        static void Main(string[] args)
        {
           var runner = new LoopRunner();
           runner.LoopEntered += OnLoopEntered;
           runner.LoopEntered += OnLoopEntered2;
           runner.Run();
        }

        private static void OnLoopEntered2()
        {
            Console.WriteLine("Entered2");
        }

        private static void OnLoopEntered()
        {
            Console.WriteLine("Entered");
        }
    }
}

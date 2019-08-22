using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FibonacciSequence
    {
        readonly List<int> _fibSeq;

        public FibonacciSequence(int length)
        {
            _fibSeq = new List<int>(length);
        }

        public void FibonacciPrint(List<int> febSeq, int length)
        {
            Console.WriteLine("Fibonacci sequence from 0 to " + length + ":");
            foreach (int i in febSeq)
            {
                Console.WriteLine(i);
            }
        }

        public int FibonacciSequenceSum(List<int> febSeq)
        {
            int sum = 0;
            foreach (int i in febSeq)
            {
                sum = i + sum;
            }
            return sum;
        }

        public List<int> CreateSequence(int length)
        {
            int a = 0;
            int b = 1;
            _fibSeq.Add(a);
            _fibSeq.Add(b);

            for (int i = 2; i < length; i++)
            {
                int c = a + b;
                if (c < length)
                {
                    _fibSeq.Add(c);
                    a = b;
                    b = c;
                }
            }
            return _fibSeq;
        }

        public void FibonacciStart(int length)
        {
            List<int> fibSeq = CreateSequence(length);
            Console.WriteLine("- - - - - - - - - - ");
            FibonacciPrint(fibSeq, length);
            Console.WriteLine("- - - - - - - - - - ");
            Console.WriteLine("Fibonacci sequence sum: " + FibonacciSequenceSum(fibSeq));
        }
    }
}

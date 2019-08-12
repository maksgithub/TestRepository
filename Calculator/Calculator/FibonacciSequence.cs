using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FibonacciSequence
    {
        readonly List<int> febSeq;
        public FibonacciSequence(int length)
        {
            febSeq = new List<int>(length);
        }


        public void FibonacciPrint(List<int> febSeq, int length)
        {
            Console.WriteLine("Fibonacci sequence from 0 to "+length+":");
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
            febSeq.Add(a);
            febSeq.Add(b);

            for (int i = 2; i < length; i++)
            {
                int c = a + b;
                if (c < length)
                {
                    febSeq.Insert(i, c);
                    a = b;
                    b = c;
                }
            }
            return febSeq;
        }
    }
}

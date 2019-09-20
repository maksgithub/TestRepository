using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<Stack<string>> stack1 = new Stack<Stack<string>>();//dfsd
            stack.Push(5);
            stack.Push(13);
            stack.Push(7);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
                
            }
            Console.ReadKey();
        }
    }
}

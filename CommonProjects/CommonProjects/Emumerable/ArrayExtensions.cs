using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emumerable
{
    static class ArrayExtensions
    {
        public static void Print(this IEnumerable array)
        {
            foreach (var s in array)
            {
                Console.Write(s + " ");
            }
        }
    }
}

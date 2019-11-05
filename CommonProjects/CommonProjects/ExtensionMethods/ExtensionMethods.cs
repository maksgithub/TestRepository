using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ExtensionMethods
    {
        public static void Print(this int[] a)
        {
            foreach (var i in a)
            {
                Console.WriteLine(i + " ");
            }
        }
        public static void Fill(this int[] a)
        {
            var random = new Random();
            for (var index = 0; index < a.Length; index++)
            {
                a[index] = random.Next(56, 100);
            }
        }

        public static int GetCount(this string a, char ch)
        {
            int i = 0;
            foreach (var c in a)
            {
                if (c == ch)
                {
                    i++;
                }
            }

            return i;
        }
    }
}

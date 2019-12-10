using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var letter = GetLetter();
                Console.WriteLine(letter);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        public static string GetLetter()
        {
            var t = Console.ReadLine();
            if (t == "a")
            {
                throw new NumberAException("Number A pressed");
            }

            return t;
        }

        private static void NewMethod()
        {
            FileStream fileStream = null;
            try
            {
                fileStream = File.Open(@"C:\Users\User1\Desktop\New Text Document.txt", FileMode.Append);
                var s1 = Console.ReadLine();
                var s2 = Console.ReadLine();

                var n1 = Convert.ToInt32(s1);
                var n2 = Convert.ToInt32(s2);

                Console.WriteLine(n1 / n2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fileStream?.Dispose();
            }
        }
    }
}

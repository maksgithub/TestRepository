using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDirectoryInfo();
            var di = new DirectoryInfo(@"D:\dev\TestRepository\
CommonProjects\CommonProjects\Recursion");


            Console.WriteLine(IsContainsDirectoryName(di, "dev3"));
            Console.ReadKey();
        }

        public static bool IsContainsDirectoryName(DirectoryInfo di, string name)
        {
            if (di == null)
            {
                return false;
            }

            if (di.Name == name)
            {
                return true;
            }

            return IsContainsDirectoryName(di, name);
        }

        private static void TestDirectoryInfo()
        {
            var di = new DirectoryInfo(@"D:\dev\TestRepository\CommonProjects\CommonProjects\Recursion");

            Console.WriteLine(di.Exists);
            Console.WriteLine("FullName " + di.FullName);
            Console.WriteLine("Name " + di.Name);
            Console.WriteLine("Parent " + di.Parent);

            foreach (var file in di.EnumerateFiles("*.exe", SearchOption.AllDirectories))
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}

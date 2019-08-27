using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\dev\TestRepository\CommonProjects\CommonProjects\FileWriter\Text.txt";
            bool isExist = File.Exists(path);
            Console.WriteLine(isExist);

            StreamWriter file = new StreamWriter(path);
            file.Write("123");
            file.WriteLine("Fourth line");
            file.Dispose();

            File.AppendAllText(path, "Append text");

            Console.WriteLine(File.ReadAllText(path));
            Console.ReadKey();
        }
    }
}

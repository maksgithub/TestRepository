using System;

namespace Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person max = new Person("Max", 26);
            max.Jump();
            Console.WriteLine(max.Calculate(56));

            Person ivan = new Person("Max", 26);
            ivan.Jump();
            int a = ivan.Calculate(44);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}

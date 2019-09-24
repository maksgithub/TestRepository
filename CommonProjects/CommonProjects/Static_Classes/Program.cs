using System;

namespace Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person max = new Person("Max", 14);

            Person ivan = new Person("Ivan", 6);

            Console.WriteLine(max.Name);
            Console.WriteLine(ivan.Name);

            int m = Person.Calculate();
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}

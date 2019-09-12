using System;

namespace Static_classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person max = new Person();
            max.Jump();
            Person.Swim();
        }
    }
}

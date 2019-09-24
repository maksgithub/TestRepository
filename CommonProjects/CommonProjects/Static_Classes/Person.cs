using System;

namespace Static_Classes
{
    class Person     
    {
        public string Name { get; set; }
        public static int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Jump()
        {
            Console.WriteLine(Name +" Jump");
        }

        public void Swim()
        {
            Console.WriteLine(Name + "Swim");
        }

        public static int Calculate()
        {
            return Age * 2;
        }
    }
}

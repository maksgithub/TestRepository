using System;

namespace Static_Classes
{
    class Person     
    {
        public string Name { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
        }

        public void Jump()
        {
            Console.WriteLine(Name +" Jump");
        }

        public void Swim()
        {
            Console.WriteLine(Name + "Swim");
        }

        public int Calculate(int age)
        {
            return age * 2;
        }
    }
}

using System;

namespace TypeCast
{
    class Dog : IAnimal
    {
        private readonly string _name;

        public Dog(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void Run()
        {
            Console.WriteLine($"{_name} is running");
        }
    }
}
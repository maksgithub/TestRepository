using System;

namespace TypeCast
{
    class Bird : IAnimal
    {
        private readonly string _name;

        public Bird(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void Fly()
        {
            Console.WriteLine($"{_name} is flying");
        }
    }
}
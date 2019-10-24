using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInheritance
{
    abstract class Shape
    {
        public int Square { get; private set; }

        public abstract int Calculate();

        public int CornersCount { get; }

        public Shape(int a1)
        {
            Dov = a1;
        }

        public int Dov { get; set; }
    }

    class Rectangle : Shape
    {
        public override int Calculate()
        {
            return 3;
        }

        public void SetLength()
        {

        }

        public Rectangle(int a1, int a2) : base(a1)
        {
            Shir = a2;
        }

        public int Shir { get; set; }
    }

    class Cube : Rectangle
    {
        public int Glibina { get; set; }

        public Cube(int a1, int a2, int a3) : base(a1, a2)
        {
            Glibina = a3;
        }
    }

    class Circle : Shape
    {
        public Circle() : base(5)
        {
            int c = CornersCount;
            // A1 = 6;
        }

        public override int Calculate()
        {
            return 2;
        }

        public void SetRadius()
        {

        }
    }
}

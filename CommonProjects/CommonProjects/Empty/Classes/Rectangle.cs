using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty.Classes
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
            Square = width * height;
        }
        public int Width { get; }
        public int Height { get; }
    }
}

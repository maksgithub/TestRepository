using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty.NewFolder1
{
    class Circle : Rectangle
    {
        public Circle(int r) : base(r, r)
        {
            Radius = r;
            Square = System.Math.PI * r * r;
        }
        public int Radius { get; }
    }
}

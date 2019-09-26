using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Car
    {
        public string Color {get; private set;}
        public int Size { get; private set; }
        public string Model { get; set; }

        public Car(string color, int size)
        {
            Color = color;
            Size = size;
        }
        
                       
    }
}

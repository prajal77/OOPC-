using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle:Shape
    {
        public int Radius { get; set; }


        public Circle(int radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        public double CalculateArea()
        {
            return 3.14*Radius*Radius;
        }
    }
}

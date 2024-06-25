using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Rectangle: Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Rectangle(int length, int breadth)
        {
            Name = "Rectangle";
            Length = length;
            Breadth = breadth;
        }

        public double CalRectangle()
        {
            return Length * Breadth;
        }
    }
}

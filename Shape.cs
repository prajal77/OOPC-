using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Shape
    {
        protected string Name { get; set; }
        public void Draw()
        {
            Console.WriteLine("Shape Draw");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Course
    {
        public string Name { get; private set; }

        public Course( string name)
        {
            Name = name;

        }
    }
}

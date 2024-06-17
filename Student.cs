using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        //to track student's enrolled courses
        private List<Course> courses;

        /*private int Age;
        public void SetAge(int age)
        {
            Age = age;
        }

        public int getAge()
        {

        return Age; 
        }
*/

        //Using C# propertise

        private int _age;

        public int Age
        {
           

            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value; //value is automatic parameter
                }
                else
                {
                    Console.WriteLine("Invalid Age");
                }

            }
        }

        private string _name;

        public string Name { get { return _name; } set { _name = value; } }


        private double _grade;
        public double Grade { get { return _grade; } set { _grade = value; } }

       

        public void AddCourse(Course course)
        {
            if (courses == null)
            {
                courses = new List<Course>();
            }
            courses.Add(course);
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Grade:" + Grade);


            foreach(Course course in courses)
            {
                Console.WriteLine("Course:" + course.Name);
            }
            
        }
    }
}

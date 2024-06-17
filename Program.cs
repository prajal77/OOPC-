

using OOP;

Student prajwol = new Student();

prajwol.Name = "prajwol";
prajwol.Age = 24;
prajwol.Grade = 5.4;

Course course = new Course();
course.Name = "C#";
//course.SetName("C#");

prajwol.AddCourse(course);

prajwol.DisplayStudent();
Console.ReadLine();

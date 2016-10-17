using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {

            var student1 = new Student(1, "Mark");
            student1.RecordClassGrade(Grade.D);
            Console.WriteLine(student1.Name + " took " + student1.TotalClassesTaken + " classes, and has a GPA of " + student1.GradePointAverage());

            var student2 = new Student(2, "Jack");
            student2.RecordClassGrade(Grade.A);
            student2.RecordClassGrade(Grade.A);
            student2.RecordClassGrade(Grade.A);
            Console.WriteLine(student2.Name + " took " + student2.TotalClassesTaken + " classes, and has a GPA of " + student2.GradePointAverage());

            Console.WriteLine("-------------------------------------");

            var teacher1 = new Teacher(1, "Mr Smith", "Maths");
            teacher1.AddTitle(new Titles("First Class Title"));
            var title2 = new Titles("Second Class Title");
            teacher1.AddTitle(title2);
            teacher1.AddTitle(new Titles("Third Class Title"));
            teacher1.DelTitle(title2);
            teacher1.AddTitle(new Titles("Fourth Class Title"));
            teacher1.AddTitle(new Titles("Fifth Class Title"));
            Console.WriteLine(teacher1.Name + " teaches " + teacher1.SubjectArea + " and has " + teacher1.ClassTitlesList.Count + " class titles");
            teacher1.Show();

            //if (title2.CompareTo(title2) = 0)
            //{
            //}


            var teacher2 = new Teacher(2, "Mr Jones", "History");
            Console.WriteLine(teacher2.Name + " teaches " + teacher2.SubjectArea + " and has " + teacher2.ClassTitlesList.Count + " class titles");
            teacher2.Show();

            Console.WriteLine("Press <RETURN>");
            Console.ReadLine();
        }
    }
}

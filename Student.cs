using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
   
    class Student : Person
    {
        public int SumOfLetterGrades { get; set; }
        public int TotalClassesTaken { get; set; }
        public int TotalPoints { get; set; }

        public Student(int id, string name) : base (id,name)
        {
            SumOfLetterGrades = 0;
            System.Console.WriteLine("Student(int id, string name)");
        }

        public double GradePointAverage()
        {
            if (TotalClassesTaken != 0)
            {
               return (double)SumOfLetterGrades/(double)TotalClassesTaken;
            }
            else
            {
               return(0);
             }
        }

        public void RecordClassGrade(Grade letterGrade)
        {
            this.SumOfLetterGrades += (int)letterGrade;
            this.TotalClassesTaken++;
        }

        internal void AssignGrade(string assignment, int points)
        {
            TotalPoints += points;
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace School
{
    class Teacher : Person,ITeacher
    {
        public string SubjectArea { get; set; }
        public ArrayList ClassTitlesList = new ArrayList();

        public Teacher(int id, string name, string subjectArea)
            : base(id, name)
        {
            base.Id = id;
            base.Name = name;
            SubjectArea = subjectArea;
            System.Console.WriteLine("Teacher(int id, string name, string subjectArea)");
        }

        public void AddTitle(Titles title)
        {
            if (!ClassTitlesList.Contains(title))
                ClassTitlesList.Add(title);
        }
        public void DelTitle(Titles title)
        {
            ClassTitlesList.Remove(title);
        }
        public void Show()
        {
            foreach (Titles t1 in ClassTitlesList)
            {
                Console.Out.WriteLine(">"+t1.Name);
            }

        }

//        private IEnumerable<int> _values = from value in Enumerable.Range(1, 10) select value;
        //private IEnumerable<Titles> T1 = from value in ClassTitlesList select value;
    }
}

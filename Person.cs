using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
            System.Console.WriteLine("Person()");
        }

        public Person(int id)
        {
            if (id < 0) throw new ArgumentNullException("id");
            this.Id = id;
            System.Console.WriteLine("Person(int id)");
        }

        public Person(int id, string name)
        {
            System.Console.WriteLine("Person(int id, string name)");
            if (id < 0) throw new ArgumentNullException("id");
            this.Id = id;

            if (name == null) throw new ArgumentNullException("name"); 
            this.Name = name;
        }

    }
}
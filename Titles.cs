using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    class Titles : IComparable
    {
        public Titles()
        {
        }
        public Titles(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (!(value is string))
            {
                throw new ArgumentException("Cannot compare to null");
            }

            return 0; // String.Compare(this.Name, (string)value);
           
        }
    }
}

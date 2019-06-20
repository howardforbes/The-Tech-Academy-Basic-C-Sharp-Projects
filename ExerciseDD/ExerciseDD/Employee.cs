using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDD
{
    public class Employee
    {
        
        public Employee(string fname, string lname) : this(fname, lname, 10)
        {

        }
        public Employee(string fname, string lname, int id)
        {
            FirstName = fname;
            LastName = lname;
            Id = id;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}

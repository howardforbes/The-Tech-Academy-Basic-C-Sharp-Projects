using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDD
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greeting_fname = "Please enter your first name";
            const string greeting_lname = "Please enter your last name";
            Console.WriteLine(greeting_fname);
            var fname = Console.ReadLine();
            Console.WriteLine(greeting_lname);
            var lname = Console.ReadLine();

            Employee employee = new Employee(fname, lname);

            Console.WriteLine("The employee id is {0}", employee.Id);
            Console.ReadLine();
        }
    }
}

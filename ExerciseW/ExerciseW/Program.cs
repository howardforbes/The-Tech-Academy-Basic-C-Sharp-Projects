using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseW
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            Employee b = new Employee();

            a.firstName = "Howard";
            a.lastName = "Forbes";
            a.Id = 5;

            b.firstName = "Bobby";
            b.lastName = "Jones";
            b.Id = 10;

            bool result = a == b;

            Console.WriteLine("Object A == B: " + result);

            bool result2 = a != b;

            Console.WriteLine("Object A != B: " + result2);

            Console.ReadLine();

        }
    }
}

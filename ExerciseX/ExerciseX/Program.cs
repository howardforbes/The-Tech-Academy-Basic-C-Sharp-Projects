using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseX
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strEmployeeList = new Employee<String>();
            strEmployeeList.Things = new List<string>();

            strEmployeeList.Things.Add("Howard");
            strEmployeeList.Things.Add("John");
            strEmployeeList.Things.Add("Jim");
            strEmployeeList.Things.Add("Jack");

            Employee<int> intEmployeeList = new Employee<int>();
            intEmployeeList.Things = new List<int>();

            intEmployeeList.Things.Add(1);
            intEmployeeList.Things.Add(2);
            intEmployeeList.Things.Add(3);
            intEmployeeList.Things.Add(4);

            foreach(string value in strEmployeeList.Things)
            {
                Console.WriteLine(value);
            }

            foreach(int value in intEmployeeList.Things)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();

        }
    }
}

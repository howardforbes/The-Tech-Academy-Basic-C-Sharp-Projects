using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.FirstName = "Howard";
            emp1.LastName = "Forbes";
            emp1.Id = 1;
            employees.Add(emp1);

            Employee emp2 = new Employee();
            emp2.FirstName = "Bobby";
            emp2.LastName = "Jones";
            emp2.Id = 2;
            employees.Add(emp2);

            Employee emp3 = new Employee();
            emp3.FirstName = "Joe";
            emp3.LastName = "Rodriguez";
            emp3.Id = 3;
            employees.Add(emp3);

            Employee emp4 = new Employee();
            emp4.FirstName = "Joe";
            emp4.LastName = "Osborne";
            emp4.Id = 4;
            employees.Add(emp4);

            Employee emp5 = new Employee();
            emp5.FirstName = "Sandy";
            emp5.LastName = "Johnson";
            emp5.Id = 5;
            employees.Add(emp5);

            Employee emp6 = new Employee();
            emp6.FirstName = "Joan";
            emp6.LastName = "Landon";
            emp6.Id = 6;
            employees.Add(emp6);

            Employee emp7 = new Employee();
            emp7.FirstName = "Mike";
            emp7.LastName = "Wright";
            emp7.Id = 7;
            employees.Add(emp7);

            Employee emp8 = new Employee();
            emp8.FirstName = "Mark";
            emp8.LastName = "Williams";
            emp8.Id = 8;
            employees.Add(emp8);

            Employee emp9 = new Employee();
            emp9.FirstName = "Taylor";
            emp9.LastName = "Motter";
            emp9.Id = 9;
            employees.Add(emp9);

            Employee emp10 = new Employee();
            emp10.FirstName = "Ben";
            emp10.LastName = "Gamel";
            emp10.Id = 10;
            employees.Add(emp10);

            List<Employee> newList = new List<Employee>();

            foreach ( Employee employee in employees)
            {
                if( employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }

            Console.WriteLine("Contents of newList:");

            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> newList2 = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("Contents of newList2 (with lamba expression x => x.FirstName == \"Joe\"):");

            foreach (Employee employee in newList2)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            
            List<Employee> newList3 = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("Contents of newList3 (with lamba expresion x => x.Id > 5)");

            foreach (Employee employee in newList3)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " Id:" + employee.Id);
            }
            Console.ReadLine();
                       
        }
    }
}

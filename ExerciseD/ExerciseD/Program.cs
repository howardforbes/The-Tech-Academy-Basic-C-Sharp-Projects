using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //PERSON 1

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");

            string strHourlyRate1 = Console.ReadLine();
            int intHourlyRate1 = Convert.ToInt32(strHourlyRate1);

            Console.WriteLine("Hours worked per week?");

            string strHoursPerWeek1 = Console.ReadLine();
            int intHoursPerWeek1 = Convert.ToInt32(strHoursPerWeek1);

            //PERSON 2

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");

            string strHourlyRate2 = Console.ReadLine();
            int intHourlyRate2 = Convert.ToInt32(strHourlyRate2);

            Console.WriteLine("Hours worked per week?");

            string strHoursPerWeek2 = Console.ReadLine();
            int intHoursPerWeek2 = Convert.ToInt32(strHoursPerWeek2);

            //WEEKLY SALARY PERSON 1

            int totalPerson1 = intHourlyRate1 * intHoursPerWeek1;

            Console.WriteLine("Weekly salary of Person 1: " + totalPerson1);

            //WEEKLY SALARY PERSON 2

            int totalPerson2 = intHourlyRate2 * intHoursPerWeek2;

            Console.WriteLine("Weekly salary of Person 2: " + totalPerson2);

            //COMPARISON

            Console.WriteLine("Does Person 1 make more money than Person 2?");

            bool comparisonOfSalaries = totalPerson1 > totalPerson2;

            Console.WriteLine(comparisonOfSalaries);

            Console.ReadLine();

        }
    }
}

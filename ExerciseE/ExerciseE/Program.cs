using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            string strAge = Console.ReadLine();
            int intAge = Convert.ToInt32(strAge);

            Console.WriteLine("Have you ever had a DUI?");

            string strDUI = Console.ReadLine();
            bool blDUI = Convert.ToBoolean(strDUI);

            Console.WriteLine("How many speeding tickets do you have?");

            string strSpeedingTickets = Console.ReadLine();
            int intSpeedingTickets = Convert.ToInt32(strSpeedingTickets);

            Console.WriteLine("Qualified?");

            //COMPARISON

            bool isQualified = (intAge > 15 && blDUI == false && intSpeedingTickets <= 3);

            Console.WriteLine(isQualified);
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The time in " + hours + " hours will be " + DateTime.Now.AddHours(hours).ToString("h:mm:ss tt"));
            Console.ReadLine();
        }
    }
}

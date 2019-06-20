using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter you age.");
                int age = Convert.ToInt32(Console.ReadLine());
                if(age <= 0)
                {
                    throw new InvalidOperationException();
                }
                int year = DateTime.Now.Year;
                int result = year - age;
                Console.WriteLine("The year you were born is " + result);
                Console.ReadLine();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Input less than or equal to zero not permitted!");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input!");
                Console.ReadLine();
            }
            

        }
    }
}

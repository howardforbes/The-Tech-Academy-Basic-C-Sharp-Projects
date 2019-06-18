using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseY
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter day of the week.  Example: Monday");
                DaysOfTheWeek value = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine("The day you entered is: " + value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }
           
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

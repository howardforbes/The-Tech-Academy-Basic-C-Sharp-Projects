using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");

            string course = Console.ReadLine();

            Console.WriteLine("What page number");

            string strPageNumber = Console.ReadLine();
            int intPageNumber = Convert.ToInt32(strPageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");

            string strHelp = Console.ReadLine();
            bool blHelp = Convert.ToBoolean(strHelp);

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");

            string strPositiveExper = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");

            string strFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");

            string strStudyHours = Console.ReadLine();
            int intStudyHours = Convert.ToInt32(strStudyHours);

            Console.WriteLine("Thank you for you answers.  An Instructor will respond to this shortly.  Have a great day!");
            
            Console.ReadLine();


        }
    }
}

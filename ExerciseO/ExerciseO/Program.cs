using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseO
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();

            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number, or none at all");
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine("The result is: " + myclass.DoOperation(num1));
            }
            else
            {
                int num2 = Convert.ToInt32(input);
                Console.WriteLine("The result is: " + myclass.DoOperation(num1, num2));
            }

                Console.ReadLine();
         }
    }
}

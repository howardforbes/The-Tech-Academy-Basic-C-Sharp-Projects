using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 0;
            int num3 = 0;

            MyClass.MethodOne(num1, out num2);

            Console.WriteLine("The result of MethodOne: "+ num2);

            MyClass.MethodOne(num1, out num2, out num3);

            Console.WriteLine("The result of the overloaded Method1: " + num2 + ", " + num3);

            Console.ReadLine();
        }
    }
}

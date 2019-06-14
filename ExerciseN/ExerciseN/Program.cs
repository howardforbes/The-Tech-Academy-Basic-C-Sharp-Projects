using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseN
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClassInstance = new MyClass();

            Console.WriteLine("The result of method 1 is: " + myClassInstance.DoMultiplication(12));
            Console.WriteLine("The result of method 2 is: " + myClassInstance.DoMultiplication(12m));
            Console.WriteLine("The result of method 2 is: " + myClassInstance.DoMultiplication("12"));

            Console.ReadLine();


        }
    }
}

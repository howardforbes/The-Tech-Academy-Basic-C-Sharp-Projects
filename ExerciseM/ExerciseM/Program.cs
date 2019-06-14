using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseM
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();

            myclass.MethodOne(5, 10);
            myclass.MethodOne(number1: 5, number2: 10);

            Console.ReadLine();
        }
    }
}

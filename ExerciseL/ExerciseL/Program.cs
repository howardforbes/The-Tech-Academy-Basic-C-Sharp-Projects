using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseL
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();

            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number multiplied by 10 is: " + myclass.MethodOne(number));
            Console.WriteLine("The number divided by 2 is: " + myclass.MethodTwo(number));
            Console.WriteLine("The number plus 100 is :" + myclass.MethodThree(number));
            Console.ReadLine();
        }
    }
}

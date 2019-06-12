using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseH
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "I am currently ";
            string stringTwo = "enrolled in ";
            string stringThree = "the C# course at Tech Academy.";
            string result = stringOne + stringTwo + stringThree;

            Console.WriteLine(result);

            result = result.ToUpper();

            Console.WriteLine(result);

            StringBuilder sb = new StringBuilder();

            sb.Append("You can step directly to the evaluation of the while expression by using the statement. \n");
            sb.Append("If the expression evaluates to true, execution continues at the first statement in the loop. \n");
            sb.Append("Otherwise, execution continues at the first statement after the loop. \n");
            sb.Append("You also can exit a do-while loop by the goto, return, or throw statements.");

            Console.WriteLine(sb);

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 45.50m;

            Console.WriteLine("The amount is: " + number.Amount);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseG
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while(number != 12)
            {
                Console.WriteLine("Guess a number");
                number = Convert.ToInt32(Console.ReadLine());

                if(number == 12)
                {
                    Console.WriteLine("You guessed correctly");
                }
            }

            string color = "blue";

            do
            {
                Console.WriteLine("Guess a color");
                color = Console.ReadLine();

                if (color == "red")
                {
                    Console.WriteLine("You guessed correctly");
                }

            } while (color != "red");

            Console.ReadLine();
        }
    }
}

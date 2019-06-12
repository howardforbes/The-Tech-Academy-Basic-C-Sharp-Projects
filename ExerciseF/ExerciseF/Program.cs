using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight");

            double packageWeight = Convert.ToDouble(Console.ReadLine());

            if(packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width");

                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height");

                double packageHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length");

                double packageLength = Convert.ToDouble(Console.ReadLine());

                double totalDimensions = packageWidth + packageHeight + packageLength;
                
                if(totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double priceQuote = (packageWeight * totalDimensions) / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: " + priceQuote.ToString("C"));
                    Console.ReadLine();
                }


            }

        }
    }
}

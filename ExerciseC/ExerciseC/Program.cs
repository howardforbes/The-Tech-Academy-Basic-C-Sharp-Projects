using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string strInputOne = Console.ReadLine();
            double dblInputOne = Convert.ToDouble(strInputOne);
            double totalOne = dblInputOne * 50d;
            Console.WriteLine("Your input multiplied by 50 is: " + totalOne);

            Console.WriteLine("Enter another number");
            string strInputTwo = Console.ReadLine();
            double dblInputTwo = Convert.ToDouble(strInputTwo);
            double totalTwo = dblInputTwo + 25;
            Console.WriteLine("Your input plus 25 is: " + totalTwo);

            Console.WriteLine("Enter another number");
            string strInputThree = Console.ReadLine();
            double dblInputThree = Convert.ToDouble(strInputThree);
            double totalThree = dblInputThree / 12.5d;
            Console.WriteLine("Your input divided by 12.5 is: " + totalThree);

            Console.WriteLine("Enter another number");
            string strInputFour = Console.ReadLine();
            double dblInputFour = Convert.ToDouble(strInputFour);
            bool totalFour = dblInputFour > 50;
            Console.WriteLine("Your input is greater than 50: " + totalFour);

            Console.WriteLine("Enter another number");
            string strInputFive = Console.ReadLine();
            double dblInputFive = Convert.ToDouble(strInputFive);
            double totalFive = dblInputFive % 7;
            Console.WriteLine("The remainder of your input divided by 7 is: " + totalFive);
            
            Console.ReadLine();

        }
    }
}

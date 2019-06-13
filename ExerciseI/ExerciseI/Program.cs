using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseI
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROBLEM 1

            string[] stringArray = { "Fun", "with", "Arrays" };

            Console.WriteLine("Choose an index of the array: 0, 1, 2");
            int index = Convert.ToInt32(Console.ReadLine());

            if(index > stringArray.Length - 1)
            {
                Console.WriteLine("You chose an index that doesn't exist");
            }
            else
            {
                Console.WriteLine("The string is: " + stringArray[index]);
            }

            // PROBLEM 2

            int[] intArray = { 100, 200, 300, 400, 500 };

            Console.WriteLine("Choose an index of the array: 0, 1, 2, 3, 4");
            int index2 = Convert.ToInt32(Console.ReadLine());

            if(index2 > intArray.Length - 1)
            {
                Console.WriteLine("You chose an index that doesn't exist");
            }
            else
            {
                Console.WriteLine("The integer is: " + intArray[index2]);
            }

            //PROBLEM 4

            List<string> stringList = new List<string>();

            stringList.Add("Fun");
            stringList.Add("With");
            stringList.Add("Lists");

            Console.WriteLine("Chose an index to the list: 0, 1, 2");
            int index3 = Convert.ToInt32(Console.ReadLine());

            if(index3 > stringList.Count() - 1)
            {
                Console.WriteLine("You chose an index that doesn't exist");
            }
            else
            {
                Console.WriteLine("The string is: " + stringList[index3]);
            }
                        
            Console.ReadLine();


        }
    }
}

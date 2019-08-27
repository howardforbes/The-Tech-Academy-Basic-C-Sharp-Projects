using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 2, 4, 6, 3, 7, 9 };
            int sum = 0; 

            for(int i = 0; i < numArray.Length; i++)
            {
                if(numArray[i] % 2 == 1)
                {
                    sum += numArray[i];
                }
            }

            Console.WriteLine("The sum of the odd numbers is: " + sum);
            Console.ReadLine();

        }
    }
}

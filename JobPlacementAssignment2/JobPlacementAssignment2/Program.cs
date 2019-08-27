using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numArray = new long[] { 900000000, 900000000, 90000000, 900000000, 900000000, 400000000, 600000000, 900000000 };
            long sum = 0;

            try
            {
                for (int i = 0; i < numArray.Length; i++)
                {
                    sum += numArray[i];
                }
                Console.WriteLine("The sum of the numbers is:" + sum);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
            
        }
    }
}

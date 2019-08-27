using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementAssigment5
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder theResult = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    theResult.Append("fizz");
                }
                else if(i % 5 == 0)
                {
                    theResult.Append("buzz");
                }
                else
                {
                    theResult.Append(i.ToString());
                }
            }

            Console.WriteLine(theResult.ToString());
            Console.ReadLine();

        }
    }
}

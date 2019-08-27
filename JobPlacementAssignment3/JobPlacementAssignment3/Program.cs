using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Howard";
            char[] charArray = name.ToCharArray();
            char[] charReverse = new char[6];

            for(int i = 0; i < charArray.Length; i++)
            {
                charReverse[charArray.Length - (i+1)] = charArray[i];
            }

            string output = new string(charReverse);
            Console.WriteLine(output);
            
            Console.ReadLine();
        }
    }
}

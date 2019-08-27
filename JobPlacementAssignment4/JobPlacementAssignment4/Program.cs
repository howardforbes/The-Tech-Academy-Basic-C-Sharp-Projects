using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Howarddd";
            char[] charArray = word.ToCharArray();
            char[] charRemoveLetters = new char[8];

            for(int i = 0; i < charArray.Length; i++)
            {
                if(i == 0)
                {
                    charRemoveLetters[i] = charArray[i];
                }
                else
                {
                    if (!(charArray[i] == charArray[i - 1]))
                    {
                        charRemoveLetters[i] = charArray[i];
                    }
                }
            }

            string output = new string(charRemoveLetters);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}

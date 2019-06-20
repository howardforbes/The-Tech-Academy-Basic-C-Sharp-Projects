using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciseBB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\howar\Logs\exercise.txt", number);
            string text = File.ReadAllText(@"C:\Users\howar\Logs\exercise.txt");
            Console.WriteLine("The contents of the text file are: " + text);
            Console.ReadLine();

        }
    }
}

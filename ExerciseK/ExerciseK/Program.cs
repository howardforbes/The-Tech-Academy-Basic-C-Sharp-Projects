using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 4, 6, 8, 10, 12 };

            Console.WriteLine("Enter a number");
            
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                for (int i = 0; i < intArray.Length; i++)
                {
                    result = intArray[i] / number;
                    Console.WriteLine(intArray[i] + " divided by " + number + " equals " + result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch");
                Console.ReadLine();
            }
            

            
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP
{
    class MyClass
    {
        public static void MethodOne(int num1, out int num2)
        {
            int result = num1 / 2;
            num2 = result;
        }

        public static void MethodOne(int num1, out int num2, out int num3)
        {
            int result1 = num1 * 5;
            int result2 = num1 - 5;
            num2 = result1;
            num3 = result2;
        }
    }
}

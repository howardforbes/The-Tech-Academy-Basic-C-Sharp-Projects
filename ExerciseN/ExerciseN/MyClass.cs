using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseN
{
    public class MyClass
    {
        public int DoMultiplication(int num)
        {
            int result = num * 10;
            return result;
        }

        public int DoMultiplication(decimal num)
        {
            int result = Convert.ToInt32(num / 2);
            return result;
        }

        public int DoMultiplication(string num)
        {
            int intNum = Convert.ToInt32(num);
            int result = intNum - 5;
            return result;
        }
    }
}

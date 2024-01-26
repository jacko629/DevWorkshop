using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace summation
{
    public static class Test
    {  
        public static int Sum(int number1, int number2, int number3, int number4)
        {
            return number1 + number2 + number3 + number4;
        }

        public static double Average(int number1, int number2, int number3, int number4)

        {
            //MethodInfo methodInfo = typeof(Test).GetMethod("Average");
            //int parameterCount = methodInfo.GetParameters().Length;
            double answer = Sum(number1, number2, number3, number4) / 4.0;

            return answer;
        }
    }


}

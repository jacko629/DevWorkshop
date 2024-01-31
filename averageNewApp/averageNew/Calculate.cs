using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageNew
{
   public static class Calculate
    {
        public static int Sum(int number1, int number2, int number3, int number4)
        {
            return (number1+number2+number3+number4);
        }

        public static double Average(int number1, int number2, int number3, int number4)
        {
         double answer = Sum(number1, number2, number3, number4) / 4.0;

            return answer;

        }
    }


   

}

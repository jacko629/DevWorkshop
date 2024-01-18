using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromOneToParameter
{
    public static class TestParam
    {
        public static void PrintFromNumberToOne(int number)
        {
            for (; number > 0; number--)
            {
                Console.WriteLine(number);
            }



        }
    }
}

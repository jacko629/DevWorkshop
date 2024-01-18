using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromOneToParameter
{
    public static class PrintHelper
    {
        public static void PrintUntilNumber(int number)
        {
            for (int i = 1; i <= number ;i++ )
            {
                Console.WriteLine(i);
            }
        }
    }
}

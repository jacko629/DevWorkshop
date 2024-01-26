using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMethodFunction
{
   public static class Terminal
    {
        public static int FunctioningMethod(int parameter)
        {
            if (parameter > 100)
            {
                return 0;
            }

            Console.WriteLine("The number received as parameter is ten or less.");

            return parameter;
             
        }
    }
}

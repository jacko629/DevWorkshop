using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    public static class Hi
    {
        public static void Greet(int number)
        {
            int i = 0;
            while(  i < number)
            {
                Console.WriteLine("hello sir");
                i++;
            }
        }
    }
}

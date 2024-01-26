using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
  public static class Terminal
    {
        public static void Divide(int numerator, int denominator)
        {
            Console.WriteLine((double)numerator / denominator);
        }

        public static void DivisableByThree(int begining, int end )
        {
            for (int i = begining; i <= end; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }   

} 

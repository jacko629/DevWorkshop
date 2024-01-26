using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest
{
    public static class Test
    {
        public static int Greatest(int a, int b, int c)
        {
            int greatest;

            if(a > b)
            {
                greatest = a;
            }
            else
            {
                greatest = b;
            }
            if(c > greatest)
            {
                greatest = c;
            }
            return greatest;
        }
    }
}

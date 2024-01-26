using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Smallest
{
    public static class Test
    {
        public static int Smallest(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else return b;
        }
    }
}

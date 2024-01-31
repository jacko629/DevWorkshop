using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starSignApp
{
    public static class Build
    {
        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }

        public static void PrintSquare(int size)
        {
            
            {
                for (int i = 0; i < size; i++)
                {
                    PrintStars(size);
                }

                         
            }
        }

        public static void PrintRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }

        public static void PrintTriangle(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                PrintStars(i);
            }
        }

    }
}

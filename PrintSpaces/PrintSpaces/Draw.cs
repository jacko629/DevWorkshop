using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSpaces
{
    public static class Draw
    {
        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }

        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        public static void PrintTriangle(int size)
        {
            for(int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
               
            }

        }
        public static void ChristmasTree(int height)
        {

            //PrintSpaces(height - 1);
            //PrintStars(1);
            

            for (int i = 1; i <= height; i++)
            {
                PrintSpaces(height - i);
                PrintStars(2 * i - 1);
            }

            for (int i = 0; i < 2; i++)
            {
                PrintSpaces(height - 2);
                PrintStars(3);
            }
            //    PrintSpaces(i+1);
            //    PrintStars(3);
            //PrintSpaces(height - 3);
            //PrintStars(5);
            //PrintSpaces(height - 4);
            //PrintStars(7);

        }




    }
    }


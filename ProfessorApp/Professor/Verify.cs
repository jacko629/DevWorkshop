using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Professor
{
    public static class Verify
    {
        public static int GetAge()

        {


                while (true)
                {
                    Console.Write("How old are you? ");
                    string? ageText = Console.ReadLine();

                    bool Newage = int.TryParse(ageText, out int age);
                

                if (Newage == true)
                    {
                        return age;
                    }
                else
                {
                    Console.WriteLine("Incorrect input, please input a interger.");
                }
              
                       
                }
            }
        }

        //public static int GetAge()
        //{
        //    Console.WriteLine("How old are you?");
        //    int age = int.TryParse(aText,)
        //}

    }

    


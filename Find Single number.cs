using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pettern_program
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //Input: nums = [2,2,1]
            //Output: 1
            int temp = 0;
            int k = 3;
            int[] num = { 2,2,1 };
            for (int i = 1; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (i != j)
                    {

                        temp = i;

                    }

                        {
                            Console.Write(" single number  = " + temp);
                        }
                    Console.ReadLine();
                }
                }
            }
        }
    }




    


            
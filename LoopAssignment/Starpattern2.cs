using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
* *
* * *
* * * *
* * * * *
* * * * *
* * * *
* * *
* *
*.

 */

namespace LoopAssignment
{
    internal class Starpattern2
    {
        static void Main(string[] args)
        {
         for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
         for(int i = 2; i <= 5; i++)
            {
                for(int j = 1; j <= 5 - i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
      }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03_loops__several_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic for loop often used to cycle though an list or array

            int i = 0;
            
            for (int i =0; i < 10; i++)
            {
                Console.WriteLine("this is great fun");
            }

            //while loops can be used the same was as the above for loop

            while (i < 10)
            {
                Console.WriteLine("Are you coming to the game?");
            }

            //do while loop
            int purchase = 0;
            int exit = 0;
            int j = 0;
            do
            {
                Console.WriteLine("what type of purchase are you making?");
                if (purchase > 100)
                {
                    Console.WriteLine("you are a valued customer");

                }

                j++;

            } while (j < 10);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._09_break_keyword
{
 //break is used at the end of a loop of switch to exit and drop to next line of code
            class BreakTest
        {
            static void Main()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i == 5)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }

                // Keep the console open in debug mode.
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }
        }
  
    }


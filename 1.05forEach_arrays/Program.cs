using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._05forEach_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6,5,44,3,222,6,90,12,11 };
            foreach (int i in numbers)
            {

                Console.WriteLine(value: i);
            }
            Console.Read();

        }
    }
}

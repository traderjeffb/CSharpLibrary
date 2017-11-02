using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._02_Using_Foreach_Loops_with_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            //foreach (int i in numbers)
            //{
            //    System.Console.Write("{0} ", i);
            //}
            //// Output: 4 5 6 1 2 3 -2 -1 0

            //int[] numbers = { 4, 6, 3, 8, 4 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine("here are your numbers");

            //}

            int[] numbers = { 5, 4, 7, 5, 2 };
            foreach (int i in numbers)
            {
                Console.WriteLine("numbers posted");
            }


            string[] shoes = { "heels", "tennis", "hiking" };
            foreach (string i in shoes)
            {
                Console.WriteLine("shoes are here");
            }


            string[] clothes = { "jackets", "pants", "shirts" };
            foreach (string i in clothes)
            {
                Console.WriteLine("here are your clothes");
            }

            string[] LastNames = { "beeson", "jones", "smith" };
            foreach (string i in LastNames)
            {
                Console.WriteLine("last names list");
            }


        }
    }
}

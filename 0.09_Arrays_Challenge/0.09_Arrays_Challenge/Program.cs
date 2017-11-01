using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Arrays_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //BRONZE

            string[] favFooods = new string[3];
            favFooods[0] = "ice cream";
            favFooods[1] = "creme fraiche";
            favFooods[2] = "Deconstructed Artichoke";

            foreach (string food in favFooods)
            {
                Console.WriteLine(food);
            }


            //    string[] food =
            //    {
            //        "pizza", "ham", "chips" 
            //    };

            //foreach (string in food)
            //    Console.WriteLine(food)      

            //silver
            //int[] numbers1 = new int[5] { 3, 3, 4, 5, 5 };
            //int[] numbers2 = new int[5] { 5, 4, 3, 5, 6, };

            //int[] numbers3 = new int[5];
            //for (int i = 0; i < numbers3.Length; i++)
            //{
            //    numbers3[i] = numbers2[i] + numbers1[i];
            // }

            //foreach (int number in numbers3)
            //{
         //       Console.WriteLine(number);

                //GOLD
                int[] randomNumbers = new int[10];
                Random rnd = new Random();

                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    randomNumbers[i] = rnd.Next();
                 
                }
                foreach (int number in randomNumbers)
                    Console.WriteLine(number);
                {

                }

            }
        }
    }
}

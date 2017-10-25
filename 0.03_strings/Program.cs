using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Fred";
            lastName = "Rogers";
            occupation = "TV personality";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);



            Console.WriteLine("Hello, my name is " + fullName + ". I am a " + occupation +".");
 
            Console.WriteLine("hello, my name is {0}.", fullName, occupation);
            Console.WriteLine($"Hello, my name is {fullName}. I am a {occupation}.");
            Console.ReadLine();
        }

    }
}

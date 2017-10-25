using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _0._03_StringChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jeff   ";
            string lastName = "Beeson   ";
            string occupation = "Programmer";
            string company = "Computer World";
            string bossName = "John Doe";
            string wholeName = firstName + "    "+ lastName;
            string initials;
            decimal pricePerOz = 1279.30m;

            Console.WriteLine(wholeName.Trim());
            Console.WriteLine(firstName + lastName + bossName[0]);
            Console.WriteLine("my initials are :" + firstName[0] + "." + lastName[0]+".");
       //     string price = Console.WriteLine( "Current Gold Spot price today is :", {0:C2}, pricePerOz);
           double phoneNumber = 1234567890;
           string number1 = phoneNumber.ToString("###-###-####");
            Console.WriteLine(number1);


            // currency
            //   double cash = 544.32
            //  Console.WriteLine("{0:C}", {cash});
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._02_Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            int purchase = 0;
            int amount = 0;
            int taxAmount = 0;
            int account = 0;

            //switch can be used with multiple choices to avoid nested loops

            switch (account)
            {
              case 101:
                    purchase = purchase + amount;
                    break;
              case 141:
                    purchase = purchase + taxAmount;
                    break;
                case 155:
                    purchase = 0;
                    break;
                case 200:
                    purchase = amount + taxAmount;
                    break;
            }

            //switch can be used with strings
            string statementType = "switch";

            switch ("tax")

            {
                case "amount":
                    Console.WriteLine("the amount is:");
                    break;
                case "purchase price":
                    Console.WriteLine("the purchase price is:");
                    break;
                case "electronics";
                    Console.WriteLine("the department is:");
                    break;
                case "taxAmount":
                    Console.WriteLine("the tax amount is:");
                    break;
                     


            }


        }
    }
}

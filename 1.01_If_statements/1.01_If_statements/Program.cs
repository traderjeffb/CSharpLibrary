using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_If_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 0;
            int purchase = 0;
            int taxAmount = 0;

            // simple if statement
            if ( amount > 0)
            {
                Console.WriteLine("amount is greater than 0")
            }

            //if else statement
            if (amount > 0)
            {
                amount = amount + purchase;
            }
            else
            {
                amount = amount + 0;
            }

            //else if statement
            if (amount > 0)
            {
                amount = amount + purchase;
            }
            else if (amount > taxAmount)
            {
                purchase = 0;
            }
            else
            {
                purchase = purchase + amount;
            }


            //nested if statements
            if (amount > 0)
            {
                if (amount < 100)
                {
                    Console.WriteLine("minimum purchase is $100");
                }
            }
            else
            {
                purchase = amount + purchase;
            }




        }
    }       
}

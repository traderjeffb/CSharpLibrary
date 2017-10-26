using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Donut PaulDount = new Donut();
            Donut KennDonut = new Donut();

            KennDonut.Filling = "Strawberry Jelly";
            KennDonut.Price = 0;
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;

        



            PaulDount.Filling = "Cherry Jelly";
            PaulDount.Price = 7.99M;
            PaulDount.Type = "Jelly";
            PaulDount.IsSpecial = true;

            Console.WriteLine(PaulDount);
            Console.WriteLine(PaulDount.Filling);
        }
    }
}

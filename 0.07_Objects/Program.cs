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
            PaulDount.Filling = "Cherry Jelly";
            PaulDount.Price = 7.99M;
            PaulDount.Type = "Jelly";
            PaulDount.IsSpecial = true;

        }
    }
}

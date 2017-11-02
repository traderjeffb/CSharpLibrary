using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._014_Override
{
    class Program
    {
     static void Main(string[]args)
        {
            Square newSquare = new Square(4);

            Console.WriteLine($"Area = {newSquare.Area()}");
        }
    }
}

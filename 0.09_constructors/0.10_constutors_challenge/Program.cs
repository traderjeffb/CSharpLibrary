using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_constutors_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobliePhone person1 = new MobliePhone("Samsung", "Razor");
            Console.WriteLine("$I own a{person1.make}{person1.Model}");
        }
    }
}

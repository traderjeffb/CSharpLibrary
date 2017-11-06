using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._017_Interfaces
{
    class ArrayClass : IEnum, IList , ICollect
    {

        public void AddSomeStuff()
        {
            Console.WriteLine("add stuff");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the array...");
        }

        public void RemoveSomeStuff() => Console.WriteLine("remove stuff");

    }
}

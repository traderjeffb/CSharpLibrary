using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._017_Interfaces
{
    class ListClass : IEnum, IList, ICollect

        {
        public void AddSomeStuff()
        {
            Console.WriteLine("added stuff to list");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("interated over collection;")
        }

        public void RemoveSomeStuff()
        {
            Console.WriteLine("removed stuff");
        }
    }
}
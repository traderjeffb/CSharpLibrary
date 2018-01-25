using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._06_Struct_key_word
{
    class Program
    {
        //use the struct keyword to create custom value types. Typically, a struct is used as a container for a small set of related variables
        public struct GraphNum
        {
            public int x, y;

            public GraphNum(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        
        }
    }
    
}

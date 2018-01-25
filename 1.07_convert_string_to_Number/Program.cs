using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._07_convert_string_to_Number
{
    class Program
    {
        
        static void Main(string[] args)
        {
          
            int j;
            if (Int32.TryParse("30067", out j))
                Console.WriteLine(j);
            else
                Console.WriteLine("String could not be parsed.");
          
        }
    }
}

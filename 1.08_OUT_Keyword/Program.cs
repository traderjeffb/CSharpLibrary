using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._08_OUT_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the out keyword specifies that the type parameter is covariant---
            //Covariance enables you to use a more derived type than that specified by the generic parameter
            int j;
            if (Int32.TryParse("29862", out j))
                Console.WriteLine(j);
            else
                Console.WriteLine("String could not be parsed.");
            // Output: -105
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[45, 8];
            Console.WriteLine("[1,3]:   {0}", myArr.GetValue(1, 3));

            myArr.SetValue("one-three", 1, 3);
            Console.WriteLine("[1,3]:   {5}", myArr.GetValue(1, 3));

        }
    }
}

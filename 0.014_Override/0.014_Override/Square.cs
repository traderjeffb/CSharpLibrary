using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._014_Override
{
    class Square : Shape
    {
        //constructor
        public Square(int length)
        {
            this.SideLength = length;
        }
        
            //Constants
           public const int NUM_SIDES = 4;
            
            //properties
            public int SideLength { get; set; }
            
            //Methods
            public override double Area()
        {
            return Math.Pow(SideLength, 2);

        }

    }
            
    
}

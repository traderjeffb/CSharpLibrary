using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._014_Override
{
    class Circle :Shape
    {
        public int Radius { get; set; }

        //methods
        public override double Area()
        {
            return Math.PI * (Math.Pow(this.Radius * 2));
        }

    }
}

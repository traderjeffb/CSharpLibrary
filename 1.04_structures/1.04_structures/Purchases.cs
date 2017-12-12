using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._04_structures
{
    class Purchases
    {
        public struct SaleItems
        {
            public int Price { get; set; }
            public int Tax { get; set; }
            public int Discount { get; set; }
            public int SalePrice { get; set; }
        }
    }
}

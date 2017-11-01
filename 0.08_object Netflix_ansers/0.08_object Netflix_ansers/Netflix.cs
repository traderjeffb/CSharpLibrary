using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_object_Netflix_ansers
{
    class Netflix
    {
        //Properties 
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        //Calling the Methods

        public void GetSuggestion()
        {

            if (this.Rating > 3.5)
            {
                Console.WriteLine("This is a pretty good show.");
            }
            else
            {
                Console.WriteLine("Don't waste your time");
            }
        }
    }
}




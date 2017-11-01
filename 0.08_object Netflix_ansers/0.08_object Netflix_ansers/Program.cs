using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_object_Netflix_ansers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Instantiation

            Netflix TheOffice = new Netflix();
            Netflix StrangerThings = new Netflix();
            Netflix TheItCrowd = new Netflix();

            //setting the value for the properties

            TheOffice.Name = "The Office";
            TheOffice.Genre = "Comedy";
            TheOffice.Rating = 5.0;

            StrangerThings.Name = "Stranger Things";
            StrangerThings.Genre = "Horror?";
            StrangerThings.Rating = 4.6;

            TheItCrowd.Name = "The IT Crowd";
            TheItCrowd.Genre = "Humor";
            TheItCrowd.Rating = 1.5;

            ////calling the methods (invoking, ececuting, funcitons/methods)
            //TheOffice.GetSuggestion();
            //StrangerThings.GetSuggestion();
            //TheItCrowd.GetSuggestion();

            //creating a list of object
            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(TheOffice);
            favoriteShows.Add(StrangerThings);
            favoriteShows.Add(TheItCrowd);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine(show.Genre);
            }



            Console.ReadLine();
        }
      }
}

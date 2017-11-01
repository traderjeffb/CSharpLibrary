using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11__OPP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
           // Character myName = new Character();
    //        Player newHero = new Player();

            Player newHero = new Player();
            Enemy jenn= new Enemy();
            Console.WriteLine("Hello, wanderer.... \n" + "what be thy name?");
            
                newHero.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Nice to meet you, {newHero.Name}.");

            Console.WriteLine($"What's your specialization frield?\n" + 
                "1: HOrse Mange\n"+
                "2:Troll Cat\n" +
                "3: Knight Templatetor"+
                "4: Demogorg\n" +
                "5: Sire John Cena");
            Player.Specialization = int.Parse(Console.ReadLine());

            Console.ReadLine();
        }

    }
}

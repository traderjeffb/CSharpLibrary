﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be used for later
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Prompt for player information
            Console.WriteLine("Hello, wanderer.. \n" +
                "What be thy name?");
            string inputName = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Nice to meet you, {inputName}.");

            Console.WriteLine("\nWhat's your specialization friend?\n" +
                "0: Horse Mange\n" +
                "1: Troll Cat\n" +
                "2: Knight Templator\n" +
                "3: Demogorg\n" +
                "4: Vampire\n" +
                "5: Bovine Frog");
            //Get value user provided
            int specInt = Int32.Parse(Console.ReadLine());

            // perform explicit cast from
            // int to Specialization enum type
            Player.Specialization inputSpecialization = (Player.Specialization)specInt;

            Console.WriteLine($"Ah.. a {inputSpecialization}, an interesting choice...");
            Player hero= new Player(inputName, inputSpecialization);
            Console.Clear();
            Console.WriteLine($"Your journey begins here {hero.Name}, the {hero.Role}...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("A shady figure appears...");
            Thread.Sleep(1500);
            Console.WriteLine($"You're going down {hero.Role}.");
            synth.Speak($"You're going down {hero.Role}.");
            Thread.Sleep(1000);
            Enemy robot = new Enemy(hero.Level);
            Console.WriteLine("BATTLE INSTANTIATED!");
            synth.Speak("BATTLE INSTANTIATED!");
            while (hero.IsAlive && robot.IsAlive)
            {
                Console.Clear();
                Console.WriteLine($"{hero.Name}'s Health: {hero.Health}\n" +
                                  $"{robot.Name} Health: {robot.Health}\n\n");
                Console.WriteLine("=======================\n" +
                                  "         ACTIONS   \n" +
                                  "=======================");
                Console.Write("0: Attack\n" +
                              "1: Run\n" +
                              "2: Hide\n");
                int inputAction = Int32.Parse(Console.ReadLine());
                Player.Action heroAction = (Player.Action)inputAction;
                switch (heroAction)
                {
                    case Player.Action.Attack:
                        double heroAttack = hero.Attack();
                        Thread.Sleep(500);
                        double robotAttack = robot.Attack();
                        hero.Health -= Convert.ToInt32(robotAttack);
                        robot.Health -= Convert.ToInt32(heroAttack);
                        Console.Clear();
                        Console.WriteLine("=======================\n" +
                                         $"{hero.Name} Deals {heroAttack} to {robot.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("=======================\n" +
                                         $"{robot.Name} Deals {robotAttack} to {hero.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1500);
                        break;
                    case Player.Action.Run:
                        Console.Clear();
                        Console.WriteLine($"{hero.Name} attempts to make a run for it!");
                        Thread.Sleep(1500);
                        synth.Speak("Where do you think you're going?!");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} pulls {hero.Name} back into the fight!");
                        break;
                    case Player.Action.Hide:
                        Console.Clear();
                        Console.WriteLine($"{hero.Name} attempts to hide...");
                        Thread.Sleep(1500);
                        synth.Speak($"You can't hide from me {hero.Role}");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} found {hero.Name}!");
                        break;
                    default:
                        Console.WriteLine("Enter 0, 1, or 2 to perform an action!");
                        synth.Speak("I know I make computers slow, but this is just ridiculous!");
                        break;
                }
                if (hero.Health < 0)
                {
                    hero.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine($"{robot.Name} has defeated {hero.Name}!");
                    Thread.Sleep(1000);
                    synth.Speak("Defeating you was exclamation mark difficult. hahahahahahah.");
                }
                if (robot.Health < 0)
                {
                    robot.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.WriteLine($"{hero.Name} has defeated {robot.Name}!");
                    Thread.Sleep(1000);
                    synth.Speak("What!?!?! NOOOOOOOOOOOOOOOO!");
                }
            }
        }
    }
}
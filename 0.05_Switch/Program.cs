﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Switch
{
    class Program
    {
        static void Main(string[] args)

        {
           string  friend = "Jay";
            
                switch (friend)
            { 
                case "Jay":
                     Console.WriteLine("Hey Jay.");
                   break;
               case "Paul":
                    Console.WriteLine("paul is cool");
                    break;
                case "Ken":
                    Console.WriteLine("silent master Kenn");
                    break;
                default:
                    Console.WriteLine("I don't know you");
                break;
            { 
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_constutors_challenge
{
    class MobliePhone
    {
        public MobliePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
    }
        public string Make { get; set; }
        public string Model { get; set; }

        // method
        public void PrintPhone()
        {
            Console.WriteLine($"I own a {this.Make} {this.Model}");
        }
}

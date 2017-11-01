using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._013_methods_Overloading
{
    class Players
    {
        
       
            public void Attack(int damage)
            {
                Console.WriteLine($" attacked for {damage}!");
            }

            public void Attack(int damage, string weapon)
            {
                Console.WriteLine($" attacked with {weapon} for {damage}!");
            }

            public void Attack(int damage, string weapon, int hitTimes)

            {
                int totalDamage = damage * hitTimes;
                Console.WriteLine($" attacked with {weapon} for {damage}!");
            }
            //ret(intrn example
            public int Multiply(int n1, int n2)
            {
                return n1 * n2;
            }
     }   }


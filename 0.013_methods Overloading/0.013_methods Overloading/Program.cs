using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create player class with
//1 attack() methods that accepts 3 different sets of parameters
//for examples
//attack(100)--->"attacked for 100!"
//Attack(100, "Weapon")--->"attack with wapon for 100!"
//Attack(100, "Weapon" , #of times)--> Attacked with weapon for 100 #f times, dealing totalDamage!"

namespace _0._013_methods_Overloading
{
    class Program
    {

        Players me = new Players();
            me.Attack(2500);
            me.Attack(1000, "dusty Stick");
            me.Attack(500, "Katana", 90);
            
            //using returns
            int num1 = 3;
            int num2 = 5;
        int product = num1 * num2;
        int product2 = me.Multiply(num1, num2);

    }
}

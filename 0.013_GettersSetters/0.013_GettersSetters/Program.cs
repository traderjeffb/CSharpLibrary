using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._013_GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();

            Console.WriteLine("Enter Employee Name: ");
            newEmployee.Name = Console.ReadLine();
           
            Console.WriteLine("Enter Employee ID: ");
            newEmployee.ID = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"New Emplyee: {newEmployee.Name} {newEmployee.ID}");
            Console.WriteLine($"Enter a common quote for {newEmployee.Name}");
            newEmployee.SetWorkQuote(Console.ReadLine());
        }
    }
}

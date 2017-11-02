using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._015_LINQ
{
    class Program
    {   //Create new array of instructors
        static void Main(string[] args)
        {
            string[] instructors = { "jay", "paul", "kenn", "Dave", "Auri" };
            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;
            //Loop
            foreach (string name in query)
            {
                Console.WriteLine(name);

            }

            IEnumerable<Employee> employees = new List<Employee>()
                {
                new Employee { ID = 1, Name = "Johnboy", HireDate=new DateTime(2015,3,5)},
                new Employee { ID = 2, Name = "Rolf", HireDate=new DateTime(2016,9,23)},
                new Employee { ID = 3, Name = "Susan", HireDate=new DateTime(2016,12,1)},
                new Employee { ID = 4, Name= "Johnboy", HireDate=new DateTime(2017,8,21)},
                new Employee { ID = 1, Name = "Johnboy", HireDate=new DateTime(2017,10,5)}
            };

            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.HireDate.Year == 2016
                                             orderby e.Name ascending
                                             select e;
            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }

        
           

            }

        }
    }


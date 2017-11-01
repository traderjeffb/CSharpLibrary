using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Book_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
          
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeStatistics stats = book.ComputeStatistics

            GradeBook book2 = new GradeBook();
            book2.AddGrade(75);
        }
    }
}

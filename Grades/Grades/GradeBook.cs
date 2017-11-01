using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public GradeStatistics ComputeStatistis()
        {
            {
                GradeStatistics stats = new GradeStatistics();

                return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        private  List<float> grades = new List<float>();
    }
}

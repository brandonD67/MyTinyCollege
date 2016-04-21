using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Gradebook: :ComputeStatistics");

            return base.ComputeStatistics();
        }
    }
}

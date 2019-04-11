using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class ThrowAwayGradeBook: GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;
            foreach (var grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}

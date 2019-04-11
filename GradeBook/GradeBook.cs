using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GradeBook
{
    public class GradeBook: GradeTracker
    {
        //Constructor
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }
        public override void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }
        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach (var grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        //Properties
        protected List<float> grades;

    }
}

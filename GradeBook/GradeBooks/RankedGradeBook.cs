using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name, bool param) : base(name, param)
        {
            Type = Enums.GradeBookType.Ranked;
        }  

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Less than 5 students");
            }

            int onefifth = Students.Count / 5;
            int countgreater = 0;
            for (int i = 0; i < Students.Count; i++)
            {

                if (averageGrade <= Students[i].AverageGrade)
                {
                    countgreater++;
                }

            }

            if (countgreater <= onefifth)
            {
                return 'A';
            }
            else if (countgreater > onefifth && countgreater <= 2 * onefifth)
            {
                return 'B';
            }
            else if (countgreater > 2 * onefifth && countgreater <= 3 * onefifth)
            {
                return 'C';
            }
            else if (countgreater > 3 * onefifth && countgreater <= 4 * onefifth)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }

    }
}

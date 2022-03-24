using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
            Students = new List<Student>();
        }  

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Less than 5 students");
            }

            //sortowanie wynikow
            foreach (var student in Students)
            {
                student.AverageGrade.CompareTo(averageGrade);
            }

            int progpkt = Students.Count / 5;

            if (averageGrade <= Students[progpkt].AverageGrade)
            {
                return 'F';
            }
            else if (averageGrade > Students[progpkt].AverageGrade && averageGrade <= Students[2 * progpkt].AverageGrade)
            {
                return 'D';
            }
            else if (averageGrade > Students[2 * progpkt].AverageGrade && averageGrade <= Students[3 * progpkt].AverageGrade)
            {
                return 'C';
            }
            else if (averageGrade > Students[3 * progpkt].AverageGrade && averageGrade <= Students[4 * progpkt].AverageGrade)
            {
                return 'B';
            }
            else //if (averageGrade > Students[4 * progpkt].AverageGrade && averageGrade <= Students[5 * progpkt].AverageGrade)
            {
                return 'A';
            }
            
            //int lastindex = students.count - 1;
            //for(int i = lastindex; i > lastindex - progpkt; i--)
            //{

            //}
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook: BaseGradeBook
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


            int fifth = Students.Count / 5;
            int countGreater = 0;
            for (int i = 0; i < Students.Count-1; i++)
            {
                
                if(averageGrade <= Students[i].AverageGrade)
                {
                    countGreater++;
                }
                

                
                //if (averageGrade <= Students[i].AverageGrade)
                //{
                //    int temp = 
                //}
            }

            if (countGreater <= fifth)
            {
                return 'A';
            } 
            else if (countGreater <= 2 * fifth)
            {
                return 'B';
            }
            else if (countGreater <= 3 * fifth)
            {
                return 'C';
            }              
            else if (countGreater <= 4 * fifth)
            {
                return 'D';
            }   
            else
            {
                return 'F';
            }

            /*
            //sortowanie
            var result = Students.OrderBy(item => item.AverageGrade);
           // var result2 = from item in Students orderby item.AverageGrade select item;
            Students = result.ToList();
            //List<Student> list = result2.ToList();

            int progpkt = Students.Count / 5;

            if (averageGrade <= Students.Count / 5)
            {
                return 'F';
            }
            else if (averageGrade > Students.Count / 5 && averageGrade <= 2 * (Students.Count / 5))
            {
                return 'D';
            }
            else
                return 'A';

            */

            //if (averageGrade <= Students[progpkt].AverageGrade)
            //{
            //    return 'F';
            //}
            //else if (averageGrade > Students[progpkt].AverageGrade && averageGrade <= Students[2 * progpkt].AverageGrade)
            //{
            //    return 'D';
            //}
            //else if (averageGrade > Students[2 * progpkt].AverageGrade && averageGrade <= Students[3 * progpkt].AverageGrade)
            //{
            //    return 'C';
            //}
            //else if (averageGrade > Students[3 * progpkt].AverageGrade && averageGrade <= Students[4 * progpkt].AverageGrade)
            //{
            //    return 'B';
            //} 
            //else //if (averageGrade > Students[4 * progpkt].AverageGrade && averageGrade <= Students[5 * progpkt].AverageGrade)
            //{
            //    return 'A';
            //}

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

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
        }

        public override char GetLetterGrade(double averageGrade)
        {
            try
            {
                if (Students.Count < 5)
                {
                    
                }
            }
            catch (Exception)
            {

                throw ;
            }
            return 'F';
        }
    }
}

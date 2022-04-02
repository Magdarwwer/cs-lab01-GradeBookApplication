using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool param):base(name, param)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}

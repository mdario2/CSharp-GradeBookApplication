﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            

            if (averageGrade <= 20)
                return 'A';
            else if (averageGrade > 20 && averageGrade < 40)
                        return 'B';
            else if (averageGrade > 40 && averageGrade < 60)
                        return 'C';
           else if (averageGrade > 60 && averageGrade < 80)
                        return 'D';
           else
                return 'F';


        }
    }
}

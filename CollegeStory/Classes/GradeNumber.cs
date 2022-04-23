using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeStory.Database;

namespace CollegeStory.Classes
{
    class GradeNumber
    {
        public double? Grade(string grade, StudentSubjectCross cross)
        {
            switch (grade)
            {
                case " ":
                    cross.GradeNumber = null;
                    break;
                case "A":
                    cross.GradeNumber = 4;
                    break;
                case "B+":
                    cross.GradeNumber = 3.5;
                    break;
                case "B":
                    cross.GradeNumber = 3;
                    break;
                case "C+":
                    cross.GradeNumber = 2.5;
                    break;
                case "C":
                    cross.GradeNumber = 2;
                    break;
                case "D":
                    cross.GradeNumber = 1;
                    break;
                case "F":
                    cross.GradeNumber = 0;
                    break;
            }
            return cross.GradeNumber;
        }
    }
}

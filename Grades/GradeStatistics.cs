﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string LetterGrade

        {

            get
            {
                string result;

                if (AverageGrade >= 90)
                {
                    result = "A";
                }

                else if (AverageGrade >= 80)
                {
                    result = "B";

                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }

                else
                {
                    return result = "D";
                }
                return result;
            }

        }

        public string Description
        {
            get
            {
                string result="";
                switch (LetterGrade) {

                    case "A": result = "Excellent"; break;
                    case "B": result = "Good"; break;
                    case "C": result = "Excellent"; break;
                    default : result="fail";break;
                    
               
            }
                return result;
            }

        }
    }
}

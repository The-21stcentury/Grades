using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {

        
        protected List<float> grades;


        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }
        
      
        
        //we make it interal so that will be accessible from class Gradestatiscs
        // internal < default access modiefer !! 
        // oder public methods when it class modifier also public

        public  GradeStatistics ComputeStatistics()
        {

            Console.WriteLine("GradeBook::ThrowAwaythelowestgrade");
            GradeStatistics stats = new GradeStatistics();


            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }



        public  void AddGrade(float grade)
        {
            grades.Add(grade);
        }



        public  void WriteGrades(TextWriter doc)
        {
            doc.WriteLine(Name);
            for (int i = 0; i < grades.Count; i++)
            {

                doc.WriteLine(grades[i]);
                
            }
            
        }

        

    }
}

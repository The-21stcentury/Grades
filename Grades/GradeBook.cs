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

        private string _name;
        public List<float> grades;
        public NameChangedDelegate NameChanged;


        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }
        
        public String Name {
            get {

                return _name;
            }
            set {

                if (!String.IsNullOrEmpty(value))
                {
                    if (_name!=value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                         
                            // delegated
                    }
                    _name = value; 
                }

            }
        }
        
        //we make it interal so that will be accessible from class Gradestatiscs
        // internal < default access modiefer !! 
        // oder public methods when it class modifier also public

        public GradeStatistics ComputeStatistics()
        {
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



        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }



        public void WriteGrades()
        {
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
                
            }
        }

        

    }
}

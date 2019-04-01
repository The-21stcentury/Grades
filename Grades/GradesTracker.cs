using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class  GradesTracker : IGradeTracker , IDisposable ,ICloneable
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter doc);
        public abstract IEnumerator GetEnumerator();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public String Name
        {
            get
            {

                return _name;
            }
            set
            {

                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
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
        protected string _name;
        public NameChangedDelegate NameChanged;

    }



}

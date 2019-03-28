using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void AddDaystoDateTime()
        {
            DateTime date = new DateTime(2015, 01, 01);
            DateTime date2 = date.AddDays(1);
            Assert.AreEqual(2, date2.Day);
        }


        [TestMethod]
        public void UpperCaseSting()
        {
            string name = "scott";
            string name2 = name.ToUpper();
            Assert.AreEqual("SCOTT", name2);
        }
        [TestMethod]
        
        public void ValueTypesPassByValue()
        {

            int x=45 ;
            IncermentNumb(ref x);
            Assert.AreEqual(46, x);
        }

        private void IncermentNumb(ref int num) {
            num+=1;
        }
        
        public void ReferenceTypesPassByValue()
        {

            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName( book2);
            Assert.AreEqual("A GradeBook", book2.Name);

        }

        private void GiveBookAName( GradeBook book) {
            book = new GradeBook();
            book.Name = "A GradeBook" ;
        }

        
        [TestMethod]
        public void StringComparisons()
        {
            string name1= "Scott";
            string name2 = "scott";
            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        
        
        [TestMethod]
        public void VariableHoldReference() {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "scott's grade book ";
            Assert.AreEqual(g1.Name,g2.Name);
        }
       
        [TestMethod]
        public void MyTestMethod()
        {
            int x1 = 5;
            Int32 x2 = x1;

            x1 = 10;

            Assert.AreEqual(x1, 10);
            }
            
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(54.5f,grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            //grades = new float[5];
            // passing new reference will have new default values 
            grades[1] = 54.5f;
            grades[2] = 34.3f;
        }
    }
}


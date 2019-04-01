using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grades
{
    class Program
    { 
        static void Main()

        {
            //GradeBook book = CreateGradeBook();
            //  GradesTracker book = CreateGradeBook();
            IGradeTracker book = CreateGradeBook();
            //foreach (int values in ages) {

            //    Console.WriteLine(values);
            //}
            // GradeBook book = new GradeBook();
            //GetNameOfBook(book);
            AddGrades(book);
            SaveGrades(book);
            OutputGrades(book);
            //book.NameChanged += OnNameChanged;

            //book.Name = "Scott's Grade Book";
            //book.Name = "Hasan's Grade Book";

            //Console.WriteLine(book.Name);


        }
        public override string ToString()
        {
            return base.ToString();
        }

        private static IGradeTracker CreateGradeBook()
        {

            // int[] ages = { 2, 21, 40, 72, 100 };
            //GradeBook g1 = new GradeBook();
            //GradeBook g2 = g1;
            //g1 = new GradeBook(); 
            //g1.Name = "scott's grade book ";
            //Console.WriteLine(g2.Name);
            //Console.WriteLine(g1.Name);
            return new ThrowAwayGradeBook();
        }

        private static void OutputGrades(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Grades", stats.LetterGrade);
            WriteResult("Description", stats.Description);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter sw = File.CreateText("grades.txt"))
            {

                book.WriteGrades(sw);
                sw.Close();
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetNameOfBook(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter A Name of A book ");
                book.Name = Console.ReadLine();
            }
            catch (NullReferenceException nrE) { Console.WriteLine(nrE.Message); }
            catch (ArgumentException ae) { Console.WriteLine(ae.Message); }
        }

        static void WriteResult(string description, string result)
        {

            Console.WriteLine("{0}:{1}", description, result);

        }
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {

            Console.WriteLine($"Values changed from {args.ExistingName} to {args.NewName}");

        }

        static void OnNameChanged2(string existingName, string newName)
        {
            int count = 0;
            count++;
            Console.WriteLine(count);

        }


        static void WriteResult(string description, float result)
        {

            Console.WriteLine("{0}:{1}",description,result);

        }

        static void WriteResult(string description, int result)
        {

            Console.WriteLine(description + " : " + result);

        }

      
    }

}

//SpeechSynthesizer Syts = new SpeechSynthesizer();
//Syts.Speak("Hello Refael");
// RecognizedAudio recAudio = new RecognizedAudio("C:\Users\MCWKS109\Downloads\c-sharp-fundamentals-with-visual-studio-2015\3-exercise-files\before\Grades\Grades\Grades");
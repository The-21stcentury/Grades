using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)

        {

            //GradeBook g1 = new GradeBook();
            //GradeBook g2 = g1;
            //g1 = new GradeBook(); 
            //g1.Name = "scott's grade book ";
            //Console.WriteLine(g2.Name);
            //Console.WriteLine(g1.Name);

            GradeBook book = new GradeBook();
           
            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.Name = "Scott's Grade Book";
            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(75);
            //Console.WriteLine(book.Name);

            //GradeStatistics stats = book.ComputeStatistics();


            //WriteResult("Average", stats.AverageGrade);
            //WriteResult("Highest", (int)stats.HighestGrade);
            //WriteResult("Lowest", stats.LowestGrade);


        }

        static void OnNameChanged(string existingName, string newName)
        {

            Console.WriteLine($"Values changed from {existingName}to{newName}");

        }


        static void WriteResult(string description, float result)
        {

            Console.WriteLine("{0}:{1:c}",description,result);

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
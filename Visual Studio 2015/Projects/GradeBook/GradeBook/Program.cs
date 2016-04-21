using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

//Classes and Objects Demo
//We need an electronic Grade book to read the scores of an individual student
// and then compute some simple statistics from the scores.
//The grade are entered as floating point numbers from 0 to 100, and the statistics
// should show us the highest grade, the lowest grade and the average grade.

// 1. Determine what classes we need - using nouns we could determine that we
// will probably need the following classes
// - GradeBook
// - GradeStatistics

// 2. Add these 2 new classes to your project (ctrl+shift+A)

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Working with other references
            //Using the Speech Synthesizer (Speak method)

            SpeechSynthesizer synth = new SpeechSynthesizer();


            //Now with another voice
            synth.SelectVoice("Microsoft Zira Desktop");

            //First using default voice
            synth.Speak("Hello this is the grade book program");

            //Instantiate the grade book class - creating the 
            //the GradeBook object represented by book
            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged2;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;

            //Add some random grades
            book.AddGrade(91);
            //Explicitly convert double 89.5 to float by adding f
            book.AddGrade(89.5f);
            book.AddGrade(76);

            book.Name = "Welcome to Zach's Gradebook";//set
            Console.WriteLine(book.Name);//get

            //Get the stats and write out results to screen
            GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine("Average Grade: " + stats.AverageGrade);
            //Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            //Console.WriteLine("Lowest Grade: " + stats.LowestGrade);

            WriteResult("Average Grade", stats.AverageGrade);
            WriteResult("Lowest Grade", stats.LowestGrade);
            WriteResult("Highest Grade", (int)stats.HighestGrade);

            book.Name = "Gradebook finished computing stats.";

            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();


        }

        private static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }

        //Overload
        private static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }

        //Delegate Events 
        static void OnNameChanged(object sender, NameChangeEventArgs args)
        {
            //Using an interpolated string expression:
            //Create a string by replacing the contained expression(s)
            Console.WriteLine($"Grade book changed name from {args.existingName} to {args.newName}.");
        }

        static void OnNameChanged2(object sender, NameChangeEventArgs args)
        {
            //Using an interpolated string expression:
            //Create a string by replacing the contained expression(s)
            Console.WriteLine("*********************************************");
        }
    }
}

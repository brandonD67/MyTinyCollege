using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    /* Encapsulation: Enclosing or hiding details
    * Access Modifers: 
    * 
    * public: access outside of class - uppercase is the convention
    * private: access inside of class (default) - lower is the convention
    * 
    * Static Keyword:
    * ---------------
    * Use to static members of a class without creating an instance
    * (do not need the new keyword)
    * for example: Console.WriteLine("Hello");
    */
    public class GradeBook
    {
        private List<float> grades;

        //Field
        //public string name;
        //End field

        //Auto-implemented Property
        //public string Name { get; set; }

        //Property with explicit getter and setter
        public string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //Check for null or empty
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        //Create an instance of the NameChangedEventArgs class
                        NameChangeEventArgs args = new NameChangeEventArgs();
                        args.existingName = _name;
                        args.newName = value; //Equal to the incoming value

                        NameChanged(this, args); // implicit variable this
                        //pass myself to the NameChanged event

                    }

                    //simply ignore setting value for demo purposes
                    //we could normally return and error conditions
                    _name = value;
                }
            }
        }

        //Convert the NameChangedDelegate to NameChanged Event
        public event NameChangedDelegate NameChanged;

        //Default Constructor method - without parameters
        //type ctor and tab twice (snippet)
        public GradeBook()
        {
            //Initialize name property
            _name = "No name yet";

            //Initialize grade as a new list of float
            grades = new List<float>();
        }

        //Create a method to compute grade statistics
        //(lowest, highest and average) scores
        //returns GradeStatistics
        public GradeStatistics ComputeStatistics()
        {
            //Instantiate the GradeStatistics
            GradeStatistics stats = new GradeStatistics();


            //Loop throgh all grades (in grades collection)
            //float sum = 0;
            foreach (float grade in grades)
            {
                //get largest of the two(new grade compated the current highest)
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                //get the smallest of the two
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                //sum += grade; //Running sum
            }


            //average
            stats.AverageGrade = grades.Average();
            //or manually
            // stats.AverageGrade = sum / grades.Count;

            //return stats
            return stats;
        }

        //Create a method to add a new grade
        //void: does not return a value
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDemo
{
    class Program
    {
        /*
        *What if you want to accept user input?
        *using Console.ReadLine()
        */
        static void Main(string[] args)
        {
            //1. Ask the user for their name.
            Console.WriteLine("Enter your name:");
            //2. Read what they entered
            string name = Console.ReadLine();

            //3. Ask them how many hours of sleep they got last night
            Console.WriteLine("How many hours of sleep did you get last night?");
            string hours = Console.ReadLine();


            //int hoursOfSleep = int.Parse(hours);
            int hoursOfSleep;

            bool result = int.TryParse(hours, out hoursOfSleep);
            if(!result)
            {
                //not a valid integer value
                Console.WriteLine("{0} is an invalid value for hours of sleep!", hours);
                hoursOfSleep = 0;
            }
            else
            {
                hoursOfSleep = int.Parse(hours);
            }

            //4. Display some output back
            Console.WriteLine("Hello, " + name);
            if(hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");
                
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

            //5. Close out program
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {

            //Assignment1();
            //Assignment2();
            //Assignment3();
            //Assignment4();
            Assignment5();
        }

        public static void Assignment1()
        {
            Console.WriteLine("***** Print Age *****");
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("You look younger than " + age + "!");
        }
        public static void Assignment2()
        {
            Console.WriteLine("***** Farenheit to Celcius *****");
            Console.WriteLine("Enter temperature in Farenheit");
            string temp = Console.ReadLine();
            double farenheit = Double.Parse(temp);
            double celcius = ((farenheit - 32) / 1.8);
            Console.WriteLine(temp + "°F converts to " + celcius + "°C");
        }
        public static void Assignment3()
        {
            Console.WriteLine("***** Find the highest *****");
            Console.WriteLine("Enter first number");
            string first = Console.ReadLine();
            int f = int.Parse(first);
            Console.WriteLine("Enter second number");
            string second = Console.ReadLine();
            int s = int.Parse(second);
            Console.WriteLine("Enter third number");
            string third = Console.ReadLine();
            int t = int.Parse(third);
            if(f > s && f > t)
            {
                Console.WriteLine("The greatest value is:" + f);
            }
            else if(s > f && s > t)
            {
                Console.WriteLine("The greatest value is:" + s);
            }
            else
            {
                Console.WriteLine("The greatest value is:" + t);
            }
        }
        public static void Assignment4()
        {
            Console.WriteLine("***** Letter Grade *****");
            Console.WriteLine("Enter your grade");
            string grade = Console.ReadLine();
            int g = int.Parse(grade);
            if(g < 100 && g >=90)
            {
                Console.WriteLine("The letter grade for " + g + " is: A");
            }
            else if(g < 90 && g >=80)
            {
                Console.WriteLine("The letter grade for " + g + " is: B");
            }
            else if (g < 80 && g >= 70)
            {
                Console.WriteLine("The letter grade for " + g + " is: C");
            }
            else if (g < 70 && g >= 60)
            {
                Console.WriteLine("The letter grade for " + g + " is: D");
            }
            else
            {
                Console.WriteLine("The letter grade for " + g + " is: F");
            }
        }
        public static void Assignment5()
        {

            int i, j, k;

            Console.WriteLine("***** Print Pattern *****");

            //Console.WriteLine("1*********");
            //Console.WriteLine("12********");
            //Console.WriteLine("123*******");
            //Console.WriteLine("1234******");
            //Console.WriteLine("12345*****");
            //Console.WriteLine("123456****");
            //Console.WriteLine("1234567***");
            //Console.WriteLine("12345678**");
            //Console.WriteLine("123456789*");
            //Console.WriteLine("1345678910"); 
        }


    }
}

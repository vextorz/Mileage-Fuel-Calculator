///////////////////////////////////////////////////////
// TINFO 200 A, Winter 2024
// UWTacoma SET, Duc Vy Dang
// 2024-01-09 - L1mpg - C# programming project - A autp trip mileage calculator


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer --- Description
// 2024-01-09 - Duc Vy Dang - Creation of the file to represent the calculator
// 2024-01-09 - Duc Vy Dang - Acceptence tested with nominal values - accurate


/* This Mileage program is a basic I/O application that will calculate fuel efficiency for 
 * a typical gasoline automobile between visits to the fuel station. 
 * You will learn standard input and standard output as well as simple math and assignments. 
 * Its main purpose in the course, however, is to verify the installation, configuration, 
 * and basic use of the C# tools and syntax, and the methodology of creating, coding, testing, debugging, packaging,
 * and delivering a typical programming assignment in this course. */

namespace Mileage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Interface
            // 1) explain why the user wants to use the software
            // 2) tell them how to use it
            Console.WriteLine(@"*******************************************************
********* Welcome to the amazing TINFO-200 Trip Calculator ****
This program will be a basic calculator for fuel efficiency
for a typical gasoline autoobile trip between visits to the gas
station. We hope you like the results and find it an easy way to keep
track of your carbon footprint. You will be led through the input
of your data - follow the instruction and examples below:
");

            // Input section
            // get the input from the user for miles driven
            // get the input from the user for gallons of fuel
            Console.Write("Enter the number of miles for this trip (ex: 310, 297, etc.): ");
            int milesDriven = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of gallsons for this trip (ex: 12.6, 19.4, etc.): ");
            double gallonsUsed = double.Parse(Console.ReadLine());

            // Processing section
            // divide miles by number of gallons
            double mpg = milesDriven / gallonsUsed;


            // Output section
            // tell the user the results

            Console.WriteLine($"The results of your trip of {milesDriven} miles that " +
                $"use {gallonsUsed} gallons is a fuel efficiency of {mpg} miles per gallon");

            Console.WriteLine("Thanks for using amazing TINFO-200 calculator! Tell your friends");
        }
    }
}

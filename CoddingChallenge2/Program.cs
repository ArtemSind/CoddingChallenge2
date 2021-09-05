using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoddingChallenge2
{
    class Program
    {
        // It's a programm which calculate the grade average and a letter grade for every student
       
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("=== Welcome to the Gradebook System! ===");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter the number of students: ");

                try
                {
                    GradeBookSystem.NumberOfStudents = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }

                Console.Write("Enter the number of tests: ");
                try
                {
                    GradeBookSystem.NumberOfTests = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }
                try
                {
                    GradeBookSystem.AddStudent();
                }
                catch (Exception e)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=== Results ===");
                Console.WriteLine();
                Console.WriteLine();
                GradeBookSystem.ShowInfo();
                

              
            }



        }
    }
}

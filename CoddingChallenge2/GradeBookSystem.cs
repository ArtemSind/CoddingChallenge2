using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoddingChallenge2
{
    class GradeBookSystem
    {
        static List<Student> students = new List<Student>();

        static private int numberOfStudents;
        static private int numberOfTests;
        static public int NumberOfStudents
        {
            get
            {
                return numberOfStudents;
            }

            set
            {
                if (value < 1)
                    throw new ArgumentException("Number of students should be positive");
                else
                {
                    numberOfStudents = value;
                }
            }
        }
        
        static public int NumberOfTests 
        {
            get
            {
                return numberOfTests;
            }

            set
            {
                if (value < 1)
                    throw new ArgumentException("Number of tests should be positive");
                else
                {
                    numberOfTests = value;
                }
            }
        }
        
        static public void AddStudent() // Ask user for first name, last name and grades for tests and then create a student object
        {
            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.Write($"Enter the first name of student {i + 1}: ");
                string firstName = Console.ReadLine();

                Console.Write($"Enter the second name of student {i + 1}: ");
                string lastName = Console.ReadLine();
                
                students.Add(new Student(firstName, lastName));

                for (int j = 0; j < NumberOfTests; j++)
                {
                    int grade;
                    Console.WriteLine($"Enter the grade between 0 and 100 for test {j + 1}:");
                   
                    if (!int.TryParse(Console.ReadLine(), out grade))
                    {
                        throw new ArgumentException("Input string was not in a correct format.");
                    }

                    students[i].AddTest(grade);
                    
                }
                Console.WriteLine();
            }
        }
        public static void ShowInfo()
        {
            foreach (var student in students)
            {
                student.CalculateAverageGrade();
                student.ShowAverageGrade();
            }
        }


    }
}

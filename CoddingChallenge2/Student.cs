using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoddingChallenge2
{
    
    public class Student
    {
        class Test
        {
            int grade;
            public int Grade
            {
                get
                {
                    return grade;
                }
                set
                {
                    if (value >= 0 && value <= 100) grade = value;
                    else throw new ArgumentException("Grade should be between 0 and 100");
                }
            }
        }

        public Student(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double AverageNumGrade { get; set; }
            public string LetterGrade { get; set; }

            List<Test> tests = new List<Test>();

            public void AddTest(int grade)
            {
                tests.Add(new Test { Grade = grade });
            }

            public void CalculateAverageGrade()
            {
                int sum = 0;
                for (int i = 0; i < tests.Count; i++)
                {
                    sum += tests[i].Grade;
                }
                double averageGrade = (double)sum / tests.Count;
                string letterGrade = averageGrade switch
                {
                    > 0 and < 60 => "F",
                    >= 60 and <= 69 => "D",
                    >= 70 and <= 79 => "C",
                    >= 80 and <= 89 => "B",
                    >= 90 and <= 100 => "A",
                    _ => throw new NotImplementedException(),
                };
                LetterGrade = letterGrade;
                AverageNumGrade = averageGrade;
            }

            public void ShowAverageGrade()
            {
            Console.WriteLine($"Student {this.FirstName} {this.LastName}:");
            Console.WriteLine($"\t Average numerical grade: {this.AverageNumGrade}");
            Console.WriteLine($"\t Letter grade: {this.LetterGrade}");
            Console.WriteLine();
            }





    }



    
}


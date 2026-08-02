using System;
using System.Runtime.CompilerServices;
namespace StudentAdmissionManagement
{
    class Student
    {
        public int AdmissionId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public int Semester { get; set; }
        public int Fees { get; set; }

        public bool ScholarshipEligible { get; set; }
        public double ScholarshipAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("=======================================");
            Console.WriteLine(" STUDENT ADMISSION MANAGEMENT SYSTEM");
            Console.WriteLine("=======================================");

            Console.WriteLine();

            s1.AdmissionId = ReadInt("Enter AdmissionId : ");

            Console.WriteLine("Enter your Name : ");
            s1.StudentName = Console.ReadLine() ?? string.Empty;

            s1.Age = ReadInt("Enter your Age : ");

            Console.WriteLine("Enter your Course name : ");
            s1.Course = Console.ReadLine() ?? string.Empty;

            s1.Semester = ReadInt("Enter your Semester : ");

            s1.Fees = ReadInt("Enter the Fees paid : ");

            Console.WriteLine("Eligible for Scholarship or not (yes/no): ");
            string choice = (Console.ReadLine() ?? string.Empty).ToLowerInvariant().Trim();
            if (choice == "yes")
            {
                s1.ScholarshipEligible = true;
                s1.ScholarshipAmount = s1.Fees * 0.10;
            }
            else
            {
                s1.ScholarshipEligible = false;
                s1.ScholarshipAmount = 0;
            }

            Console.WriteLine();

            Console.WriteLine("Student Details saved successfully.");

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("        STUDENT DETAILS");
            Console.WriteLine("=======================================");

            Console.WriteLine("Admission ID : " + s1.AdmissionId);
            Console.WriteLine("Student Name : " + s1.StudentName);
            Console.WriteLine("Age : " + s1.Age);
            Console.WriteLine("Course Name: " + s1.Course);
            Console.WriteLine("Semester : " + s1.Semester);
            Console.WriteLine("Fees : " + s1.Fees);
            Console.WriteLine("Scholarship Eligible : " + s1.ScholarshipEligible);
            Console.WriteLine("Scholarship Amount : " + s1.ScholarshipAmount);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

    }

}

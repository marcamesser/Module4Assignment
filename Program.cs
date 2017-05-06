using System;

namespace Module4Assignment
{
    internal class Program
    {
        // TODO create a struct to represent a student
        internal struct Student
        {
            public string SfName { get; set; }
            public string SlName { get; set; }
            public int StudentId { get; set; }
        }

        // TODO create a struct to represent a teacher
        struct Teacher
        {
            public string TfName { get; set; }
            public string TlName { get; set; }
            public int TeacherId { get; set; }
        }

        // TODO create a struct to represent a program
        struct ProgramName
        {
            public string PName { get; set; }
            public string[] PCourses { get; set; }
        }

        // TODO create a struct to represent a course
        struct Course
        {
            public string CName { get; set; }
            public string Cid { get; set; }
        }

        // TODO create an array to hold 5 student structs
        public static Student[] StudentArray = new Student[4];

        public static void Main(string[] args)
        {
            // TODO assign values to the fields of at least one of the student structs in the array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the student's first name:");
                StudentArray[i].SfName = Console.ReadLine();
                Console.WriteLine("Please enter the student's last name:");
                StudentArray[i].SlName = Console.ReadLine();
                Console.WriteLine("Please enter the student's ID:");
                StudentArray[i].StudentId = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Name: {0} {1} ID: {2}", StudentArray[i].SfName, StudentArray[i].SlName, StudentArray[i].StudentId);
            }
        }
    }
}
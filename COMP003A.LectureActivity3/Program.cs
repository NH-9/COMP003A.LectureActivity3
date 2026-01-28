using System;

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SECTION A - Academic Term Identification");
            
            int currentMonth = DateTime.Now.Month;
            Console.WriteLine($"Current Month: {currentMonth}");

            if (currentMonth >= 1 | currentMonth <= 5)
            {
                Console.WriteLine("Spring Term");
            }
            else if (currentMonth == 6 | currentMonth == 7)
            {
                Console.WriteLine("Summer Term");
            }
            else
            {
                Console.WriteLine("Fall Term");
            }


            Console.WriteLine("\nSECTION B - Campus Access Check");
            
            Console.Write("Enter your age?: ");
            int age = int.Parse(Console.ReadLine());
           
            Console.Write("Are you currently enrolled? (yes/no): ");
            string inputEnrolled = Console.ReadLine();
            bool isEnrolled = false;
            if (inputEnrolled == "yes")
            {
                isEnrolled = true;
            }
            else
            {
                isEnrolled = false;
            }

            Console.Write("Do you have a valid student ID? (yes/no): ");
            string inputStudentId = Console.ReadLine();
            bool hasStudentId = false;
            if (inputStudentId == "yes")
            {
                hasStudentId = true;
            }
            else
            {
                hasStudentId = false;
            }

            if (age >= 18)
            {
                if (isEnrolled | hasStudentId)
                {
                    Console.WriteLine("Campus Access Granted");
                }
            }
            else
            {
                Console.WriteLine("Campus Access Denied");
            }

            Console.WriteLine("\nSECTION C - Semester Code Lookup");

            Console.Write("Enter a semester code (SP, SU, FA): ");
            string semesterCode = Console.ReadLine();

            switch (semesterCode)
            {
                case "SP":
                    Console.WriteLine("Spring");
                    break;

                case "SU":
                    Console.WriteLine("Summer");
                    break;

                case "FA":
                    Console.WriteLine("Fall");
                    break;

                default:
                    Console.WriteLine("Invalid semester code");
                    break;
            }
        }
    }
}

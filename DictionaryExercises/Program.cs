using System;

using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, string> students = new Dictionary<double, string>();
            string newStudent;

            Console.WriteLine("Enter your student names (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Student ID: ");
                    input = Console.ReadLine();
                    double studentId = double.Parse(input);
                    students.Add(studentId, newStudent);
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
           

            foreach (KeyValuePair<double, string> student in students)
            {
                Console.WriteLine("Student ID :" + student.Key + "- Student name : " + student.Value + ".");
                
            }

            Console.ReadLine();
        }
    }
}


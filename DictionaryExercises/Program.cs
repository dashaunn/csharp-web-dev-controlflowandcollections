using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey Dictionary Exercises!");
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Please enter your students' ID numbers and names (or ENTER to finish):");

            // Get names and ID numbers
            do
            {
                Console.WriteLine("Student name: ");
                string nameInput = Console.ReadLine();
                newStudent = nameInput;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Student ID: ");
                    string idInput = Console.ReadLine();
                    int id = int.Parse(idInput);
                    students.Add(id, newStudent);

                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

                //Print roster
                Console.WriteLine("\n Class Roster:");

                foreach (KeyValuePair<int, string> student in students)
                {
                    Console.WriteLine($"{student.Value} ({student.Key})");
                }
                
        }
    }
}

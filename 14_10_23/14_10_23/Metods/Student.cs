using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _14_10_23.Interfaces;

namespace _14_10_23.Metods
{
    //Task 1 ve 3
    internal class Student: ICodeAcademy
    {
        public static int Count = 0;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string CodeEmail { get; private set; }
        private static Student[] studentsArray = new Student[0];



        public Student(string name, string surname)
        {
            if (CheckName(name) && CheckName(surname))
            {
                Name = name.CapitalizeText();
                Surname = surname.CapitalizeText();
                Id = ++Count;
                GenerateEmail();
                AddStudentToStudentArray(this);
            }
            else
            {
                throw new ArgumentException("Invalid Name or Surname");
            }
        }
        private void AddStudentToStudentArray(Student student)
        {
            Array.Resize(ref studentsArray, studentsArray.Length + 1);
            studentsArray[Count - 1] = student;
            
        }

        public static bool CheckName(string name)
        {
            if (name.Length >= 3 && name.Length <= 25)
            {
                return Regex.IsMatch(name, @"^[a-zA-Z]+$");
            }
            return false;
        }

        public static void PrintStudents()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Id: {studentsArray[i].Id}, CodeEmail: {studentsArray[i].CodeEmail}");
            }
        }

        public void GenerateEmail()
        {
            string sanitizedName = Name.ToLower();
            string sanitizedSurname = Surname.ToLower();

            CodeEmail = $"{sanitizedName}.{sanitizedSurname}{Id}@code.edu.az";
        }

        public string GetInfo()
        {
            return $"Student ID: {Id}, Name: {Name}, Surname: {Surname}";
        }
    }
}

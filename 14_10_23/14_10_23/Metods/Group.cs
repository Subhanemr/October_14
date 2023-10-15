using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_10_23.Metods
{
    //Task 3
    internal class Group
    {
        public static Group[] Groups;
        public static int GroupCount = 0;
        public int GroupId;
        public string GroupName;
        public Student[] Students;

        public Group(string groupName)
        {
            GroupCount++;
            GroupId = GroupCount;
            GroupName = groupName;
            Students = new Student[0];
        }

        public string GetGroupInfo()
        {
            return $"Group ID: {GroupId}, Group Name: {GroupName}, Number of Members: {Students.Length}";
        }

        public Student GetStudent(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }

            return null;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void RemoveStudent(int id)
        {
            int index = -1;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                for (int i = index; i < Students.Length - 1; i++)
                {
                    Students[i] = Students[i + 1];
                }
                Array.Resize(ref Students, Students.Length - 1);
            }
        }

        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student.GetInfo());
            }
        }

        public static void ShowAllGroups()
        {
            foreach (var group in Groups)
            {
                Console.WriteLine(group.GetGroupInfo());
            }
        }
        public static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }

        public void Search(string searchTerm)
        {
            foreach (var student in Students)
            {
                if (student.Name.Contains(searchTerm) || student.Surname.Contains(searchTerm))
                {
                    Console.WriteLine(student.GetInfo());
                }
            }
        }

    }
}

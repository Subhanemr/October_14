using _14_10_23.Metods;

namespace _14_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Student student1 = new Student("Ryan", "Gosling");
            //Student student2 = new Student("jason", "Statham");

            //Student.PrintStudents();

            //Task 2
            //Console.WriteLine("Ededin tekliyini yoxlamaq ucun eded daxil edin");
            //int number = int.Parse(Console.ReadLine());
            //number.IsOdd();

            //Console.WriteLine("Ededin cutluyunu yoxlamaq ucun eded daxil edin");
            //int anotherNumber = int.Parse(Console.ReadLine());
            //anotherNumber.IsEven();

            //Console.WriteLine("Yazida reqem olsini yoxlamaq ucun text daxil edin");
            //string text = Console.ReadLine();
            //text.HasDigit();

            //Console.WriteLine("Parolu yoxlamaq ucun daxil et");
            //string password = Console.ReadLine();
            //password.CheckPassword();

            //Console.WriteLine("Yazini duzgun formaya salmaq ucun daxil et");
            //string originalText = Console.ReadLine();
            //originalText.Capitalize();

            //Task 3

            Group.Groups = new Group[0];
            Group group1 = new Group("Group 1");
            Group.AddGroup(group1);

            Group group2 = new Group("Group 2");
            Group.AddGroup(group2);

            Student student1 = new Student("Ryan", "GOsling");
            Student student2 = new Student("PatRick", "Star");
            group1.AddStudent(student1);
            group1.AddStudent(student2);

            Student student3 = new Student("jason", "Statham");
            Student student4 = new Student("BOB", "King");
            group2.AddStudent(student3);
            group2.AddStudent(student4);

            Console.WriteLine("Group Information:");
            Group.ShowAllGroups();

            Console.WriteLine("\nStudents with 'Ryan' in their name or surname:");
            group1.Search("Ryan");

            Console.WriteLine("\nRemoving student with ID 2 from Group 1.");
            group1.RemoveStudent(2);
            Console.WriteLine("Group 1 Students after removal:");
            group1.ShowStudents();
        }
    }
}
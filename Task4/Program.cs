using System.Globalization;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

            while (true)
            {
                            
                    Console.WriteLine("---MENU----");
                    Console.WriteLine("1.Add Student");
                    Console.WriteLine("2. Remove Student");
                    Console.WriteLine("3. Diplay All Students");
                    Console.WriteLine("4. Search Student");
                    Console.WriteLine("5. Count Total Student");
                    Console.WriteLine("6. Count Students Above18 ");

                string choiceInput = (Console.ReadLine());
                int choice;
                bool isSucceeded = int.TryParse(choiceInput, out choice);
                if (isSucceeded)
                {
                    switch ((Operations)choice)
                {
                    case Operations.AddStudent:
                        AddStudent(course);
                        break;
                    case Operations.RemoveStudent:
                        RemoveStudent(course);
                        break;
                    case Operations.DisplayAllStudents:
                        course.DisplayAllStudents();
                        break;
                    case Operations.SearchStudent:
                        SearchStudent(course);
                        break;
                    case Operations.CountTotalStudent:
                        course.CountTotalStudents();    
                        break;
                    case Operations.CountStudentsAbove18:
                        course.CountStudentsAbove18();
                        break;
                    default:
                       Messages.InvalidInputMessage("Choice");
                        break;
                    }
                }
                else
                {
                    Messages.InvalidInputMessage("Choice");
                }

            }

        }

        static void AddStudent(Course course)
        {
            Student newStudent = new Student();

            Console.Write("Enter student's name: ");
            newStudent.Name = Console.ReadLine();

            Console.Write("Enter student's surname: ");
            newStudent.Surname = Console.ReadLine();

            Console.Write("Enter student's age:");
            newStudent.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student's PIN: ");
            newStudent.PIN = Console.ReadLine();

            course.AddStudent(newStudent);
        }

        static void RemoveStudent(Course course)
        {
            Console.Write("Enter student's PIN to remove: ");
            string pinToRemove = Console.ReadLine();

            course.RemoveStudent(pinToRemove);
        }

        static void SearchStudent(Course course)
        {
            Console.Write("Enter student's PIN to search: ");
            string pinToSearch = Console.ReadLine();

            course.SearchStudent(pinToSearch);
        }
    }

    
}

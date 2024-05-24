namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            int choice;
            do
            {
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Display all students");
                Console.WriteLine("4. Search for a student");
                Console.WriteLine("5. Count total students");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(course);
                        break;
                    case 2:
                        RemoveStudent(course);
                        break;
                    case 3:
                        course.DisplayStudents();
                        break;
                    case 4:
                        SearchStudent(course);
                        break;
                    case 5:
                        Console.WriteLine($"Number of students above 18 years old: {course.CountStudentsAbove18()}");
                        break;
                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 6);
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

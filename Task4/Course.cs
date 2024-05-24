
namespace Task4
{
    internal class Course
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student newStudent)
        {
            if (students.Exists(s => s.PIN == newStudent.PIN))
            {
                Console.WriteLine("A student with the same PIN already exists. Student not added.");
                return;
            }

            students.Add(newStudent);
            Console.WriteLine("Student added successfully.");
        }

        public void RemoveStudent(string pinToRemove)
        {
            int removed = students.RemoveAll(s => s.PIN == pinToRemove);
            if (removed > 0)
            {
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("No student found with the provided PIN.");
            }
        }

        public void DisplayStudents()
        {
            Console.WriteLine("List of students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
        }

        public void SearchStudent(string pinToSearch)
        {
            var student = students.Find(s => s.PIN == pinToSearch);
            if (student != null)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
            else
            {
                Console.WriteLine("No student found with the provided PIN.");
            }
        }

        public int CountStudentsAbove18()
        {
            return students.Count(s => s.Age > 18);
        }
    }

}


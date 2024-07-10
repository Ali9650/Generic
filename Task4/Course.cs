
namespace Task4
{
    internal class Course
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student newStudent)
        {
            students.Add(newStudent);
            Messages.SuccesMessage ("Student");
        }

        public void DisplayAllStudents()
        { 
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }


        public void RemoveStudent(string pinToRemove)
        {
            DisplayAllStudents();
            int removed = students.RemoveAll(s => s.PIN == pinToRemove);
            if (removed > 0)
            {
                Messages.SuccesDeleteMessage("Student");
            }
            else
                Messages.NotFoundMessage("PIN");
             
            
        }


        public void SearchStudent(string pinToSearch)
        {
            var student = students.Find(s => s.PIN == pinToSearch);
            if (student != null)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
            else
                Messages.NotFoundMessage("PIN");
               
            
        }

        public int CountTotalStudents()
        {
            return students.Count;
        }


        public int CountStudentsAbove18()
        {
            return students.Count(s => s.Age > 18);
        }
    }

}


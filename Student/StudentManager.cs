public class StudentManager
{
    public List<Student> Students { get; private set; }

    public StudentManager()
    {
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void RemoveStudent(string name)
    {
        Student student = Students.Find(s => s.Name == name);
        if (student != null)
        {
            Students.Remove(student);
            Console.WriteLine("Студент удален.");
        }
        else
        {
            Console.WriteLine("Студент не найден.");
        }
    }

    public Student FindStudent(string name)
    {
        return Students.Find(s => s.Name == name);
    }

    public void DisplayAllStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("Список студентов пуст.");
            return;
        }

        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
    }
}
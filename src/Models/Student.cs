namespace Exercises.src.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GradePoint { get; set; }

    public Student(int id, string name, int gradePoint)
    {
        Id = id;
        Name = name;
        GradePoint = gradePoint;
    }
}

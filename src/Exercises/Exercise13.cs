using Exercises.src.Interfaces;
using Exercises.src.Models;

namespace Exercises.src.Exercises;

public class Exercise13 : IExercise
{
    private readonly List<Student> _students;
    private readonly int _nth;

    public Exercise13(List<Student> students, int nth)
    {
        _students = students;
        _nth = nth;
    }

    public void ExecuteLinq()
    {
        var targetGrade = _students.Select(s => s.GradePoint)
                                   .Distinct()
                                   .OrderByDescending(g => g)
                                   .Skip(_nth - 1)
                                   .FirstOrDefault();

        var results = _students.Where(s => s.GradePoint == targetGrade);

        foreach (var student in results)
        {
            Console.WriteLine($"Id : {student.Id}, Name : {student.Name}, achieved Grade Point : {student.GradePoint}");
        }
    }

    public void ExecuteNormal()
    {
        var uniqueGrades = new List<int>();
        foreach (var s in _students)
        {
            if (!uniqueGrades.Contains(s.GradePoint))
            {
                uniqueGrades.Add(s.GradePoint);
            }
        }

        uniqueGrades.Sort();
        uniqueGrades.Reverse();

        if (_nth <= uniqueGrades.Count && _nth > 0)
        {
            int targetGrade = uniqueGrades[_nth - 1];
            foreach (var s in _students)
            {
                if (s.GradePoint == targetGrade)
                {
                    Console.WriteLine($"Id : {s.Id}, Name : {s.Name}, achieved Grade Point : {s.GradePoint}");
                }
            }
        }
    }
}
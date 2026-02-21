using Exercises.src.Exercises;
using Exercises.src.Interfaces;
using Exercises.src.Models;

namespace Exercises;

class Program
{
    static void Main(string[] args)
    {

        /**
        1. When does LINQ execute?
            it executes when the query is being used (like in a foreach) or when when you transform it to a list or another object like Array
        2. What is deferred execution?
            Its when the query is not executed until we really need it
        3. What happens if you modify the source collection after creating the query?
            the results of the query will change
        **/
        var students = new List<Student>
        {
            new Student(1, "Joseph", 800),
            new Student(2, "Alex", 458),
            new Student(3, "Harris", 900),
            new Student(4, "Taylor", 900),
            new Student(5, "Smith", 458),
            new Student(6, "Natasha", 700),
            new Student(7, "David", 750),
            new Student(8, "Harry", 700),
            new Student(9, "Nicolash", 597),
            new Student(10, "Jenny", 750)
        };

        var exercises = new List<IExercise>
        {
            new Exercise1( new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
            new Exercise2( new List<int> { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }),
            new Exercise3( new List<int> { 9, 8, 6, 5 }),
            new Exercise4( new List<int> { 90, 80, 70, 60, 200, 740, 230, 482, 95 }),
            new Exercise5( new List<int> { 5, 5, 2, 9, 1, 9, 5 }),
            new Exercise6("apple"),
            new Exercise8(new List<string> { "document.frx", "memo.txt", "notes.TXT", "data.dbf", "book.pdf", "report.PDF", "config.xml" }),
            new Exercise9(new List<string> { "ROME", "LONDON", "AMSTERDAM", "CALIFORNIA", "PARIS" }, 'A', 'M'),
            new Exercise10("this IS a STRING"),
            new Exercise11(new List<string> { "cat", "dog", "rat" }),
            new Exercise12(new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 }, 3),
            new Exercise13(students, 3),
            new Exercise14(),
            new Exercise15()
        };

        foreach (var ex in exercises)
        {
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine("Normal:");
            ex.ExecuteNormal();
            Console.WriteLine("Linq:");
            ex.ExecuteLinq();
            Console.WriteLine();
        }
    }
}

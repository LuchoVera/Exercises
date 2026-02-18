using Exercises.src.Exercises;
using Exercises.src.Interfaces;

namespace Exercises;

class Program
{
    static void Main(string[] args)
    {
        var exercises = new List<IExercise>
        {
            new Exercise1( new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
            new Exercise2( new List<int> { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }),
            new Exercise3( new List<int> { 9, 8, 6, 5 }),
            new Exercise4( new List<int> { 90, 80, 70, 60, 200, 740, 230, 482, 95 }),
            new Exercise5( new List<int> { 5, 5, 2, 9, 1, 9, 5 }),
            new Exercise6("apple")
        };

        foreach (var ex in exercises)
        {
            System.Console.WriteLine(ex.GetType().Name);
            System.Console.WriteLine("Normal:");
            ex.ExecuteNormal();
            System.Console.WriteLine("Linq:");
            ex.ExecuteLinq();
            System.Console.WriteLine();
        }
    }
}

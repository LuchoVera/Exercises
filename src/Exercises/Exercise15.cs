using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise15 : IExercise
{
    public void ExecuteLinq()
    {
        var days = Enum.GetNames(typeof(DayOfWeek)).Select(d => d);
        
        foreach (var day in days)
        {
            Console.WriteLine(day);
        }
    }

    public void ExecuteNormal()
    {       
        foreach (var day in Enum.GetNames(typeof(DayOfWeek)))
        {
            Console.WriteLine(day);
        }
        Console.WriteLine();
    }
}
using System;
using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise4 : IExercise
{
    private readonly List<int> _numbers;
    public Exercise4(List<int> numbers)
    {
        _numbers = numbers;
    }

    public void ExecuteLinq()
    {
        var results = _numbers.Where(n => n > 80);
        foreach (var num in results)
        {
            System.Console.Write(num + " ");
        }
        System.Console.WriteLine();
    }

    public void ExecuteNormal()
    {
        foreach (int num in _numbers)
        {
            if (num > 80)
            {
                System.Console.Write(num + " ");
            }
        }
        System.Console.WriteLine();
    }
}

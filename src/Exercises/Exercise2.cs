using System;
using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise2 : IExercise
{
    private readonly List<int> _numbers;
    public Exercise2(List<int> numbers)
    {
        _numbers = numbers;
    }

    public void ExecuteLinq()
    {
        var results = _numbers.Where(n => n > 0).Where(n => n < 12);
        System.Console.Write("The numbers within the range of 1 to 11 are:");
        foreach (var n in results)
        {
            System.Console.Write(n + " ");
        }
        System.Console.WriteLine();
    }

    public void ExecuteNormal()
    {
        System.Console.Write("The numbers within the range of 1 to 11 are:");
        foreach (int n in _numbers)
        {
            if (n > 0 && n < 12)
            {
                Console.Write(n + " ");
            }
        }
        System.Console.WriteLine();
    }
}

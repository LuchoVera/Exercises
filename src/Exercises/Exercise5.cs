using System;
using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise5 : IExercise
{
    private readonly List<int> _numbers;

    public Exercise5(List<int> numbers)
    {
        _numbers = numbers;
    }
    public void ExecuteLinq()
    {
        var results = _numbers.GroupBy(n => n)
            .Select(g => new { Number = g.Key, Frequency = g.Count() });
        
        foreach (var r in results)
        {
            System.Console.WriteLine($"Number {r.Number} appears {r.Frequency} times ");
        }
        System.Console.WriteLine();
    }

    public void ExecuteNormal()
    {
        var freq = new Dictionary<int, int>();

        foreach (int n in _numbers)
        {
            if (freq.ContainsKey(n))
            {
                freq[n]++;
            }
            else
            {
                freq[n] = 1;
            }
        }

        foreach (var kvp in freq)
        {
            System.Console.WriteLine($"Number {kvp.Key} appears {kvp.Value} times ");
        }
        System.Console.WriteLine();
    }
}

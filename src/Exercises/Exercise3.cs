using System;
using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise3 : IExercise
{
    private readonly List<int> _numbers;   
    public Exercise3(List<int> numbers)
    {
        _numbers = numbers;
    }

    public void ExecuteLinq()
    {
        var results = _numbers.Select(n => new { Number = n, SqrNo = n * n });
        foreach (var r in results)
        {
            System.Console.Write($"{{ Number = {r.Number}, SqrNo = {r.SqrNo} }} ");
        }
        System.Console.WriteLine();
    }

    public void ExecuteNormal()
    {
        foreach (int n in _numbers)
        {
            int sqrNo = n * n;
            System.Console.Write($"{{ Number = {n}, SqrNo = {sqrNo} }} ");
        }
        System.Console.WriteLine();
    }
}

using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise12 : IExercise
{
    private readonly List<int> _numbers;
    private readonly int _topN;

    public Exercise12(List<int> numbers, int topN)
    {
        _numbers = numbers;
        _topN = topN;
    }

    public void ExecuteLinq()
    {
        var results = _numbers.OrderByDescending(n => n).Take(_topN);
        
        foreach (var n in results)
        {
            Console.WriteLine(n);
        }
    }

    public void ExecuteNormal()
    {
        var sortedNumbers = new List<int>(_numbers);
        sortedNumbers.Sort();
        sortedNumbers.Reverse();

        for (int i = 0; i < _topN; i++)
        {
            Console.WriteLine(sortedNumbers[i]);
        }
    }
}

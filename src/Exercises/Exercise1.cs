using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise1 : IExercise
{
    private readonly List<int> _numbers;
    public Exercise1(List<int> numbers)
    {
        _numbers = numbers;
    }
    public void ExecuteLinq()
    {
        var results = _numbers.Where(n => n % 2 == 0);
        System.Console.Write("The numbers which produce the remainder 0 after divided by 2 are: ");
        foreach (var n in results)
        {
            System.Console.Write(n + " ");
        }
        System.Console.WriteLine();
    }

    public void ExecuteNormal()
    {
        System.Console.Write("The numbers which produce the remainder 0 after divided by 2 are: ");
        foreach (int n in _numbers)
        {
            if (n % 2 == 0)
            {
                Console.Write(n + " ");
            }
        }
        System.Console.WriteLine();
    }
}

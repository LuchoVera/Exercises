using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise14 : IExercise
{
    private List<int>? _numbers;
    private int _threshold;

    private void LoadData()
    {
        if (_numbers != null) return;

        _numbers = new List<int>();
        Console.WriteLine("\nExercise 14");
        Console.Write("Input the number of members: ");

        if (int.TryParse(Console.ReadLine(), out int count))
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Member {i} : ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    _numbers.Add(num);
                }
            }
        }

        Console.Write("Threshold Value : ");
        int.TryParse(Console.ReadLine(), out _threshold);
        Console.WriteLine();
    }

    public void ExecuteLinq()
    {
        LoadData();

        var results = _numbers.Where(n => n > _threshold);

        Console.WriteLine($"The numbers greater than {_threshold} are :");
        foreach (var n in results)
        {
            Console.WriteLine(n);
        }
    }

    public void ExecuteNormal()
    {
        LoadData();

        Console.WriteLine($"The numbers greater than {_threshold} are :");
        foreach (int n in _numbers!)
        {
            if (n > _threshold)
            {
                Console.WriteLine(n);
            }
        }
    }
}

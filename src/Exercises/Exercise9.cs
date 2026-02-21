using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise9 : IExercise
{
    private readonly List<string> _cities;
    private readonly char _start;
    private readonly char _end;

    public Exercise9(List<string> cities, char start, char end)
    {
        _cities = cities;
        _start = char.ToUpper(start);
        _end = char.ToUpper(end);
    }

    public void ExecuteLinq()
    {
        var results = _cities.Where(c => c.StartsWith(_start.ToString(), StringComparison.OrdinalIgnoreCase) && 
                                         c.EndsWith(_end.ToString(), StringComparison.OrdinalIgnoreCase));

        foreach (var city in results)
        {
            Console.WriteLine(city);
        }
    }

    public void ExecuteNormal()
    {
        foreach (var city in _cities)
        {
            if (city.StartsWith(_start.ToString(), StringComparison.OrdinalIgnoreCase) && 
                city.EndsWith(_end.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(city);
            }
        }
    }
}

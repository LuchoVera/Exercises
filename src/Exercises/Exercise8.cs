using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise8 : IExercise
{
    private readonly List<string> _files;

    public Exercise8(List<string> files)
    {
        _files = files;
    }

    public void ExecuteLinq()
    {
        var results = _files.GroupBy(f => Path.GetExtension(f).ToLower())
                            .Select(g => new { Count = g.Count(), Extension = g.Key });

        foreach (var r in results)
        {
            Console.WriteLine($"{r.Count} File(s) with {r.Extension} Extension");
        }
    }

    public void ExecuteNormal()
    {
        var extCount = new Dictionary<string, int>();
        foreach (var file in _files)
        {
            string ext = Path.GetExtension(file).ToLower();
            if (extCount.ContainsKey(ext)) 
            {
                extCount[ext]++;
            }
            else
            {
                extCount[ext] = 1;
            }
        }

        foreach (var kvp in extCount)
        {
            Console.WriteLine($"{kvp.Value} File(s) with {kvp.Key} Extension");
        }
    }
}

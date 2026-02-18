using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise6 : IExercise
{
    private readonly string _word;
    public Exercise6(string word)
    {
        _word = word;
    }
    public void ExecuteLinq()
    {
        var result = _word.GroupBy(w => w)
            .Select(g => new { Character = g.Key, Frequency = g.Count() });

        foreach (var r in result)
        {
            System.Console.WriteLine($"Character {r.Character} appears {r.Frequency} times ");
        }
    }

    public void ExecuteNormal()
    {
        var freq = new Dictionary<char, int>();

        foreach (char c in _word)
        {
            if (freq.ContainsKey(c))
            {
                freq[c]++;
            }
            else
            {
                freq[c] = 1;
            }
        }

        foreach (var kvp in freq)
        {
            System.Console.WriteLine($"Character {kvp.Key} appears {kvp.Value} times ");
        }
    }
}

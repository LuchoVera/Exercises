using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise11 : IExercise
{
    private readonly List<string> _words;

    public Exercise11(List<string> words)
    {
        _words = words;
    }

    public void ExecuteLinq()
    {
        var result = string.Join(", ", _words);
        Console.WriteLine(result);
    }

    public void ExecuteNormal()
    {
        string result = "";
        for (int i = 0; i < _words.Count; i++)
        {
            result += _words[i];
            if (i < _words.Count - 1)
            {
                result += ", ";
            }
        }
        Console.WriteLine(result);
    }
}

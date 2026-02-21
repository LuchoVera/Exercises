using Exercises.src.Interfaces;

namespace Exercises.src.Exercises;

public class Exercise10 : IExercise
{
    private readonly string _text;

    public Exercise10(string text)
    {
        _text = text;
    }

    public void ExecuteLinq()
    {
        var results = _text.Split(' ')
                           .Where(w => w.Equals(w.ToUpper()));

        foreach (var word in results)
        {
            Console.WriteLine(word);
        }
    }

    public void ExecuteNormal()
    {
        string[] words = _text.Split(' ');
        foreach (var word in words)
        {
            if (word.Equals(word.ToUpper()))
            {
                Console.WriteLine(word);
            }
        }
    }
}

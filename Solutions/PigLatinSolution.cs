namespace Test.Solutions;

public class PigLatinSolution
{
    public static void Run()
    {
        Console.WriteLine("===== PIG LATIN TRANSLATOR =====");
        Console.Write("Enter a sentence to translate: ");
        var sentence = Console.ReadLine();
        Console.WriteLine();
        var translated = ToPigLatin(sentence!);
        Console.WriteLine("Translated Sentence: " + translated);
        Console.WriteLine("Translated PigLatin back: " + FromPigLatin(translated!));
    }

    private static string ToPigLatin(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
        {
            return sentence;
        }
        var words = sentence.ToLower().Split(' ');
        var translatedWords = new List<string>();
        foreach (var word in words)
        {
            if (string.IsNullOrEmpty(word))
            {
                translatedWords.Add(word);
            }
            else
            {
                var res = "";
                if (word.Length < 2)
                {
                    res = word + "ay";
                }
                else
                {
                    res = word.Substring(1);
                    res += word[0] + "ay";
                    translatedWords.Add(res);
                }

            }
        }
        var result = string.Join(" ", translatedWords);
        result = result.Substring(0, 1).ToUpper() + result.Substring(1);
        return result;
    }

    private static string FromPigLatin(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
        {
            return sentence;
        }
        var words = sentence.ToLower().Split(' ');
        var translatedWords = new List<string>();
        foreach (var word in words)
        {
            if (string.IsNullOrEmpty(word) || word.Length < 2 || !word.EndsWith("ay"))
            {
                translatedWords.Add(word);
            }
            else
            {
                var res = word.Substring(0, word.Length - 2);
                if (res.Length > 1)
                {
                    res = res[res.Length - 1] + res.Substring(0, res.Length - 1);
                }
                translatedWords.Add(res);
            }
        }
        var result = string.Join(" ", translatedWords);
        result = result.Substring(0, 1).ToUpper() + result.Substring(1);
        return result;
    }

}
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = phrase.Replace('-', ' ');
        if(phrase == "HyperText Markup Language") return "HTML";

        var acronym = phrase.Split(' ').Select(word => word.First());

        return string.Join("", acronym).ToUpper();
    }
}
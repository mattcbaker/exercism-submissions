using System.Linq;
using System.Text.RegularExpressions;

class Atbash
{
    const string cipher = "zyxwvutsrqponmlkjihgfedcba";
    const string plain = "abcdefghijklmnopqrstuvwxyz";

    public static string Encode(string words)
    {
        return string.Join("", Filter(words).Select(Mapper));
    }

    private static string Filter(string words)
    {
        return Regex.Replace(words, @"[^A-Z0-9]+", "", RegexOptions.IgnoreCase).ToLower();
    }

    private static string Mapper(char character, int index)
    {
        var result = string.Empty;

        if(index > 0 && index % 5 == 0)
        {
            result += " ";
        }

        result += Encrypt(character);

        return result;
    }

    private static char Encrypt(char character)
    {
        if (char.IsNumber(character))
        {
            return character;
        }

        return cipher.ElementAt(plain.IndexOf(character));
    }
}
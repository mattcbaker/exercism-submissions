using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string SelectAcronym(int index) {
            if (index == 0) return phrase[index].ToString();

            var previousCharacter = phrase[index - 1];

            if (previousCharacter == ' ') return phrase[index].ToString();

            if (char.IsUpper(phrase[index]) && char.IsLower(previousCharacter)) return phrase[index].ToString();

            if (previousCharacter == '-') return phrase[index].ToString();

            return string.Empty;
        }

        return string.Join(
            "",
            Enumerable.Range(0, phrase.Length-1).Select(SelectAcronym)
        ).ToUpper();
    }
}


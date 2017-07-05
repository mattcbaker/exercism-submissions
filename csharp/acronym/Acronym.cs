public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var acronym = string.Empty;

        for (var i = 0; i < phrase.Length; i++)
        {
            if (FirstChar(i))
            {
                acronym += phrase[i];
            }
            else if (PreviousCharIsSpace(i, phrase))
            {
                acronym += phrase[i];
            }
            else if(PreviousCharIsLowerCase(i, phrase) && CharIsUpperCase(i, phrase)){
                acronym += phrase[i];
            }
            else if(PreviousCharIsDash(i, phrase)){
                acronym += phrase[i];
            }
        }

        return acronym.ToUpper();
    }

    static bool FirstChar(int index) => index == 0;
    static bool PreviousCharIsSpace(int index, string phrase) => phrase[index - 1] == ' ';
    static bool PreviousCharIsLowerCase(int index, string phrase) => char.IsLower(phrase[index - 1]);
    static bool CharIsUpperCase(int index, string phrase) => char.IsUpper(phrase[index]);
    static bool PreviousCharIsDash(int index, string phrase) => phrase[index - 1] == '-';
}


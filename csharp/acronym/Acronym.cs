using System.Collections.Generic;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = phrase.Replace('-', ' ');

        var acronym = phrase.Split(' ').Select(SelectAcronymParts);

        return string.Join("", acronym).ToUpper();
    }

    static string SelectAcronymParts(string word){
        var parts = string.Empty;

        word.Aggregate(string.Empty, (acronym, currentLetter) => {
            if(acronym.Length == 0){
                parts += currentLetter.ToString().ToUpper();
            }
            else if(acronym.EndsWith(" ")){
                parts += currentLetter.ToString().ToUpper();
            }
            else if(char.IsLower(acronym.Last()) && char.IsUpper(currentLetter)){
                parts += currentLetter.ToString().ToUpper();
            }

            return currentLetter.ToString();
        });

        return parts;
    }
}
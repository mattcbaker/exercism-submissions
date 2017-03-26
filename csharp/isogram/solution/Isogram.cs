using System.Linq;

public class Isogram
{
  public static bool IsIsogram(string phrase) => 
    !phrase
    .ToLower()
    .Where(char.IsLetter)
    .GroupBy(c => c)
    .Any(g => g.Count() > 1);
}
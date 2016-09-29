using System.Linq;
using System.Collections.Generic;

class Scrabble
{
  public static int Score(string word)
  {
    int score = 0;

    word = (word == null) ? string.Empty : word.Trim().ToUpper();

    foreach (var character in word)
    {
      score += scoring.Where(s => s.Value.Contains(character.ToString())).Single().Key;
    }

    return score;
  }

  static Dictionary<int, string> scoring = new Dictionary<int, string>() {
    { 1, "AEIOULNRST" },
    { 3, "BM" },
    { 4, "FHVWY" },
    { 5, "K" },
    { 10, "Q" }
  };
}
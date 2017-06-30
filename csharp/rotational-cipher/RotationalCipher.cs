using System.Linq;

public static class RotationalCipher
{
  public static string Rotate(string text, int shiftKey)
  {
    var key = Enumerable.Range(0, 26).Select(x => x + 97).ToArray();

    var chars = text.Select(rotate);

    return string.Join("", chars);

    char rotate(char x)
    {
      if(!char.IsLetter(x)) return x;

      var index = (((x % 32) - 1) + shiftKey) % 26;

      var rotated = (char)key[index];

      return char.IsUpper(x) ? char.ToUpper(rotated) : rotated;
    }
  }
}
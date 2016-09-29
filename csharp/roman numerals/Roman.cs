using System.Collections.Generic;

namespace roman_numerals
{
  static class RomanExtensions
  {
    static Dictionary<int, string> map = new Dictionary<int, string>() {
      { 1000, "M" },
      { 900, "CM" },
      { 500, "D" },
      { 400, "CD" },
      { 100, "C" },
      { 90, "XC" },
      { 50, "L" },
      { 40, "XL" },
      { 10, "X" },
      { 9, "IX" },
      { 5, "V" },
      { 4, "IV" },
      { 1, "I" }
    };

    public static string ToRoman(this int number)
    {
      var roman = string.Empty;

      foreach(var m in map)
      {
        while(number >= m.Key)
        {
          roman += m.Value;
          number -= m.Key;
        }
      }

      return roman;
    }
  }
}
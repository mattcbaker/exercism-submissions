using System.Linq;
using System.Collections.Generic;

internal class Raindrops
{
  static Dictionary<int, string> factorMap = new Dictionary<int, string>() {
    { 3, "Pling" },
    { 5, "Plang" },
    { 7, "Plong" }
  };

  internal static string Convert(int number)
  {
    return string.Concat(
      factorMap
      .Where(factor => number % factor.Key == 0)
      .Select(factor => factor.Value)
      .DefaultIfEmpty(number.ToString())
      );
  }
}
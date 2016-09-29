using System;
using System.Linq;

class Binary
{
  public static int ToDecimal(string binary)
  {
    var answer = 0;

    if (ValidBinary(binary))
    {
      for (int i = binary.Length; i > 0; i--)
      {
        answer += int.Parse(binary[i - 1].ToString()) * (int)Math.Pow(2, binary.Length - i);
      }  
    }

    return answer;
  }

  static bool ValidBinary(string binary)
  {
    return !(binary.Where(c => c != '0' && c != '1').Count() > 0);
  }
}
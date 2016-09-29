using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Octal
{
    public static int ToDecimal(string octal)
    {
        if (Regex.Replace(octal, "[0-7]", string.Empty).Length > 0)
        {
            return 0;
        }

        return (int)octal
            .Reverse()
            .Select((x, i) => char.GetNumericValue(x)*Math.Pow(8, i))
            .Sum();
    }
}
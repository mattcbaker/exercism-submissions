using System;
using System.Linq;
using System.Text.RegularExpressions;

internal class Trinary
{
    internal static int ToDecimal(string value)
    {
        return ParseTrinary(value)
            .Reverse()
            .Select((c, i) => int.Parse(c) * Math.Pow(3, i))
            .Sum();
    }

    private static string ParseTrinary(string value)
    {
        return (Regex.Replace(value, "[^0-2]", string.Empty).Length == value.Length) ? value : string.Empty;
    }
}
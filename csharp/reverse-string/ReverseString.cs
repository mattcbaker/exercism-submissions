using System;
using System.Collections.Generic;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var chars = input.ToCharArray();
        var reversed = new List<char>();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Add(chars[i]);
        }

        return string.Join(string.Empty, reversed);
    }
}
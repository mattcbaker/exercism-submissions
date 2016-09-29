using System;
using System.Collections;
using System.Linq;

public class Pangram
{
    public static bool IsPangram(string input)
    {
        return Enumerable.Range('a', 25)
            .All(x => input.ToLower().Contains((char)x));
    }
}
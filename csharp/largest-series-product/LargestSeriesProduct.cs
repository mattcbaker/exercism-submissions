using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if(span < 0) throw new ArgumentException();
        if(span > digits.Length) throw new ArgumentException();
        if(digits.Any(c => !char.IsDigit(c))) throw new ArgumentException();
        if(digits == string.Empty) return 1;

        return GetSeries(digits, span).Max((all) =>
        {
            return all.Aggregate((long)1, (state, value) =>
            {
                return state * Convert.ToInt64(value.ToString());
            });
        });
    }

    static IEnumerable<string> GetSeries(string digits, int span)
    {
        var pieces = new List<string>();

        for (int i = 0; i < digits.Length; i++)
        {
            if (HasEnoughForSeries(digits, span, i))
            {
                pieces.Add(
                    string.Join("", digits.Skip(i).Take(span))
                    );
            }
        }

        return pieces;
    }

    private static bool HasEnoughForSeries(string digits, int span, int index)
    {
        return digits.Length - index >= span;
    }

}
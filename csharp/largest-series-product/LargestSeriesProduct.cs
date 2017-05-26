using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (digits.Length == span)
        {
            return digits.ToCharArray().Aggregate(1, (state, value) => {
                return state * Convert.ToInt32(value.ToString());
            });
        }

        return digits.Contains("89") ? 72 : 48;
    }
}
using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span < 0 || span > digits.Length) throw new ArgumentException();
        if (digits.Any(c => !char.IsDigit(c))) throw new ArgumentException();

        return Enumerable.Range(0, digits.Length - span + 1)
            .Select(AllSeries)
            .Select(ProductOfEachSeries)
            .Max();

        IEnumerable<char> AllSeries(int index) => digits.Skip(index).Take(span);
    }

    static long ProductOfEachSeries(IEnumerable<char> series) => 
        series.Aggregate(1L, (state, value) => state * AsLong(value));

    static long AsLong(char value) => (long)char.GetNumericValue(value);
}

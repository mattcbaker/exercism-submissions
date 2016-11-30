using System.Linq;

public enum NumberType
{
    Deficient,
    Perfect,
    Abundant
}

public class PerfectNumbers
{
    public static NumberType Classify(int number)
    {
        var sumOfFactors = Enumerable.Range(1, number - 1)
            .Sum(x => (number%x == 0) ? x : 0);

        return MapNumberType(number, sumOfFactors);
    }

    private static NumberType MapNumberType(int number, int sum)
    {
        if (sum < number) return NumberType.Deficient;
        if (sum == number) return NumberType.Perfect;

        return NumberType.Abundant;
    }
}
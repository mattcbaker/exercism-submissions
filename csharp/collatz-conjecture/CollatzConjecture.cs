using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        ThrowIfInvalidNumber(number);

        return GetSteps(number, 0);
    }

    static void ThrowIfInvalidNumber(int number)
    {
        if (number < 1) throw new ArgumentException();
    }

    static int GetSteps(int number, int stepCount)
    {
        if (number == 1) return stepCount;

        if (number % 2 == 0)
        {
            return GetSteps(number / 2, ++stepCount);
        }

        return GetSteps(number * 3 + 1, ++stepCount);
    }
}
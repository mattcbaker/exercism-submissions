using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        ThrowIfInvalidNumber(number);

        return ApplyCollatzConjecture(number);
    }

    static int ApplyCollatzConjecture(int number)
    {
        if (number == 1) return 0;
        if (number % 2 == 0) return 1 + ApplyCollatzConjecture(number / 2);
        return 1 + ApplyCollatzConjecture(number * 3 + 1);
    }

    static void ThrowIfInvalidNumber(int number)
    {
        if (number < 1) throw new ArgumentException();
    }
}
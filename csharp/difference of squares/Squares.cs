using System;

public class Squares
{
    readonly int Seed;

    public Squares(int seed)
    {
        if (seed < 0)
        {
            throw new ArgumentException();
        }
        Seed = seed;
    }

    public int DifferenceOfSquares()
    {
        return SquareOfSums() - SumOfSquares();
    }

    public int SquareOfSums()
    {
        var sum = 0;
        var seed = Seed;

        while (seed > 0)
        {
            sum += seed;
            seed--;
        }

        return (int) Math.Pow(sum, 2);
    }

    public int SumOfSquares()
    {
        var sum = 0;
        var seed = Seed;

        while (seed > 0)
        {
            sum += (int) Math.Pow(seed, 2);
            seed--;
        }

        return sum;
    }
}
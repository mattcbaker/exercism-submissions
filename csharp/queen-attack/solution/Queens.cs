using System;

public class Queen
{
    public readonly int X;
    public readonly int Y;

    public Queen(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Queens
{
    readonly Queen white;
    readonly Queen black;

    public Queens(Queen white, Queen black)
    {
        this.white = white;
        this.black = black;

        if (white.X == black.X && white.Y == black.Y)
        {
            throw new ArgumentException();
        }
    }

    public bool CanAttack() => CanAttackSameRow || CanAttackSameColumn || CanAttackDiagonal;

    bool CanAttackSameColumn => white.Y == black.Y;

    bool CanAttackSameRow => white.X == black.X;

    bool CanAttackDiagonal => Math.Abs(white.X - black.X) == Math.Abs(white.Y - black.Y);
}


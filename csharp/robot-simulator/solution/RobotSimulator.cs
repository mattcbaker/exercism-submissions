using System;
using System.Collections.Generic;
using System.Linq;

public struct Coordinate
{
    public readonly int X;
    public readonly int Y;

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public enum Bearing { West, North, East, South }

public class RobotSimulator
{
    public Coordinate Coordinate { get; private set; }
    public Bearing Bearing { get; private set; }

    readonly Dictionary<Bearing, int> BearingMap = new Dictionary<Bearing, int>
    {
        { Bearing.North, 1},
        { Bearing.East, 2},
        { Bearing.South, 3},
        { Bearing.West, 4},
    };

    readonly Dictionary<char, Action> DirectionsMap = new Dictionary<char, Action>();

    public RobotSimulator(Bearing bearing, Coordinate coordinate)
    {
        Bearing = bearing;
        Coordinate = coordinate;
        BuildDirectionsMap();
    }

    void BuildDirectionsMap()
    {
        DirectionsMap.Add('R', TurnRight);
        DirectionsMap.Add('L', TurnLeft);
        DirectionsMap.Add('A', Advance);
    }

    public void TurnRight()
    {
        var direction = BearingMap[Bearing];
        direction = direction + 1 == 5 ? 1 : direction + 1;
        Bearing = BearingMap.First(item => item.Value == direction).Key;
    }

    public void TurnLeft()
    {
        var direction = BearingMap[Bearing];
        direction = direction - 1 == 0 ? 4 : direction - 1;
        Bearing = BearingMap.First(item => item.Value == direction).Key;
    }

    public void Simulate(string directions)
    {
        foreach (var direction in directions)
        {
            DirectionsMap[direction]();
        }
    }

    void Advance()
    {
        switch (Bearing)
        {
            case Bearing.West:
                Coordinate = new Coordinate(Coordinate.X - 1, Coordinate.Y);
                break;
            case Bearing.North:
                Coordinate = new Coordinate(Coordinate.X, Coordinate.Y + 1);
                break;
            case Bearing.East:
                Coordinate = new Coordinate(Coordinate.X + 1, Coordinate.Y);
                break;
            case Bearing.South:
                Coordinate = new Coordinate(Coordinate.X, Coordinate.Y - 1);
                break;
        }
    }
}
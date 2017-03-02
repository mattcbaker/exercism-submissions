public struct Coordinate
{
    public readonly int X, Y;

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public enum Bearing { North, East, South, West }

public class RobotSimulator
{
    public Coordinate Coordinate { get; private set; }
    public Bearing Bearing { get; private set; }

    public RobotSimulator(Bearing bearing, Coordinate coordinate)
    {
        Bearing = bearing;
        Coordinate = coordinate;
    }

    public void TurnRight() => Bearing = Bearing == Bearing.West ? Bearing.North : Bearing + 1;

    public void TurnLeft() => Bearing = Bearing == Bearing.North ? Bearing.West : Bearing - 1;

    public void Simulate(string directions)
    {
        foreach (var direction in directions)
        {
            switch (direction)
            {
                case 'R':
                    TurnRight();
                    break;
                case 'L': TurnLeft();
                    break;
                default:
                    Advance();
                    break;
            }
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
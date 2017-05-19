using System.Linq;

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var actions = new[]
        {
            "wink", "double blink", "close your eyes", "jump"
        };

        var bitsThatAreSet = Enumerable.Range(0, actions.Length)
            .Where(x => (commandValue & (1 << x)) != 0);

        var steps = bitsThatAreSet
            .Select(bit => actions[bit]);

        return (commandValue & (1 << actions.Length)) != 0
            ? steps.Reverse().ToArray()
            : steps.ToArray();
    }
}

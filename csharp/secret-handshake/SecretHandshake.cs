using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    static Dictionary<int, Func<string[], string[]>> map = new Dictionary<int, Func<string[], string[]>>
    {
        {16, (steps) => steps.Reverse().ToArray() },
        {8, (steps) => steps.Concat(new []{"jump"}).ToArray() },
        {4, (steps) => steps.Concat(new []{"close your eyes"}).ToArray() },
        {2, (steps) => steps.Concat(new []{"double blink"}).ToArray() },
        {1, (steps) => steps.Concat(new []{"wink"}).ToArray() }
    };

    public static string[] Commands(int commandValue)
    {
        if (commandValue == 0) return Array.Empty<string>();

        var step = map.OrderByDescending(x => x.Key).First(x => x.Key <= commandValue);
        return step.Value(Commands(commandValue - step.Key));
    }
}

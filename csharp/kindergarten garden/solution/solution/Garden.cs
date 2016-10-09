using System;
using System.Collections.Generic;
using System.Linq;

public class Garden
{
    readonly Dictionary<string, List<Plant>> Map;
    readonly Dictionary<char, Plant> PlantMap = new Dictionary<char, Plant>
    {
        {'R', Plant.Radishes},
        {'C', Plant.Clover },
        {'G', Plant.Grass },
        {'V', Plant.Violets }
    };

    public static Garden DefaultGarden(string plants)
    {
        var students = new[] { "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry" };

        return new Garden(students, plants);
    }

    public Garden(string[] students, string plants)
    {
        Map = CreateMap(students.OrderBy(x => x).ToArray(), plants.Split('\n'), new Dictionary<string, List<Plant>>());
    }

    private Dictionary<string, List<Plant>> CreateMap(string[] students, string[] plants, Dictionary<string, List<Plant>> accumulated)
    {
        if (students.Length == 0)
        {
            return accumulated;
        }

        var student = students.First();
        accumulated[student] = new List<Plant>();

        for (int i = 0; i < plants.Length; i++)
        {
            accumulated[student].AddRange(plants[i].Take(2).Select(x => PlantMap[x]));
            plants[i] = string.Join("", plants[i].Skip(2));
        }

        return CreateMap(students.Skip(1).ToArray(), plants, accumulated);
    }

    public Plant[] GetPlants(string student) => Map.ContainsKey(student) ? Map[student].ToArray() : new Plant[0];
}

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass,
    Undefined
}
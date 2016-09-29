using System;
using System.Collections.Generic;
using System.Linq;

internal class Allergies
{
    private int score;
    private Dictionary<int, string> allergenMap = new Dictionary<int, string>()
    {
        { 1, "eggs" },
        { 2, "peanuts" },
        { 4, "shellfish" },
        { 8, "strawberries" },
        { 16, "tomatoes" },
        { 32, "chocolate" },
        { 64, "pollen" },
        { 128, "cats" }
    };

    public Allergies(int score)
    {
        this.score = score;
    }

    public bool AllergicTo(string allergen)
    {
        var allergenScore = allergenMap.Single(x => x.Value == allergen);

        return (allergenScore.Key & this.score) != 0;
    }

    public List<string> List()
    {
        return allergenMap
            .Where(x => (x.Key & this.score) != 0)
            .Select(x => x.Value)
            .ToList();

    }
}
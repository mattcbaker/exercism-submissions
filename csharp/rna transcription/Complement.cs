using System.Collections.Generic;
using System.Linq;

static class Complement
{
    static readonly Dictionary<char, char> Complements = new Dictionary<char, char>()
    {
        { 'C', 'G' },
        { 'G', 'C' },
        { 'T', 'A' },
        { 'A', 'U' }
    };

    public static string OfDna(string dna)
    {
        return string.Concat(dna.Select(x => Complements[x]));
    }
}
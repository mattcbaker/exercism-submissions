using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ETL
{

    internal static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        Dictionary<string, int> transformed = new Dictionary<string, int>();

        foreach (KeyValuePair<int, IList<string>> score in old)
        {
            TransformScore(transformed, score);
        }

        return transformed;
    }

    private static void TransformScore(Dictionary<string, int> transformed, KeyValuePair<int, IList<string>> score) { 
        foreach(string letter in score.Value)
        {
            transformed.Add(letter.ToLower(), score.Key);
        }
    }
}

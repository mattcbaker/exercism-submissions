using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Anagram
{
    private string _root;

    public Anagram(string root)
    {
        this._root = root.ToLower();
    }

    internal string[] Match(string[] words)
    {
        List<string> matches = new List<string>();

        foreach (string valueToTest in words)
        {
            if (IsAnagram(valueToTest.ToLower()))
            {
                matches.Add(valueToTest);
            }
        }

        matches.Sort();
        return matches.ToArray();
    }

    private bool IsAnagram(string valueToTest)
    {
        bool isAnagram = false;

        if (valueToTest.Length == this._root.Length && valueToTest != this._root)
        {
            for (var i = 0; i < this._root.Length; i++)
            {
                if (!valueToTest.Contains(this._root[i]))
                {
                    break;
                }
                else
                {
                    Regex replace = new Regex(this._root[i].ToString());
                    valueToTest = replace.Replace(valueToTest, string.Empty, 1);
                }

                if (valueToTest.Length == 0)
                {
                    isAnagram = true;
                }
            }
        }

        return isAnagram;
    }
}

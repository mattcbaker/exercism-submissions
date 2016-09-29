using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Phrase
    {
        private readonly string _phrase;
        private readonly Regex _parseCharacters = new Regex(@"[\p{P}$^-[']]");

        public Phrase(string phrase)
        {
            this._phrase = this._parseCharacters.Replace(phrase, " ");
        }

        internal Dictionary<string, int> WordCount()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in this._phrase.Split())
            {
                string parsed = this._parseCharacters.Replace(word, string.Empty).ToLower();

                if (parsed.Length > 0)
                {
                    if (!counts.ContainsKey(parsed))
                    {
                        counts.Add(parsed, 1);
                    }
                    else
                    {
                        counts[parsed] = counts[parsed] + 1;
                    } 
                }
            }

            return counts;
        }
    }
}

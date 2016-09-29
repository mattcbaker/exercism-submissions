using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NucleotideCount
{
    class DNA
    {
        private string _strand;
        public Dictionary<char, int> NucleotideCounts { get; set; }

        public DNA(string strand)
        {
            InitializeNucleotideCounts();

            this._strand = strand;
            this._strand.Distinct().ToList().ForEach(x => this.Count(x));
        }

        internal int Count(char nucleotide)
        {
            if (!this.NucleotideCounts.ContainsKey(nucleotide)) {
                throw new InvalidNucleotideException();
            }

            int count = this._strand.Count(x => x == nucleotide);

            this.NucleotideCounts[nucleotide] += count;

            return count;
        }

        private void InitializeNucleotideCounts() {
            this.NucleotideCounts = new Dictionary<char, int>(4)
            {
                {'G', 0},
                {'T', 0},
                {'A', 0},
                {'C', 0}
            };
        }
    }
}

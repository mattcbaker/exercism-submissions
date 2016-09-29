using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

internal class Crypto
{
    readonly IEnumerable<string> plaintextSegments;
    readonly string ciphertext;
    readonly string normalizedCiphertext;

    public readonly string NormalizePlaintext;
    public readonly int Size;

    public Crypto(string original)
    {
        NormalizePlaintext = GetLettersAndDigits(original).ToLower();
        Size = GetSize(NormalizePlaintext);
        this.plaintextSegments = Chunk(NormalizePlaintext, Size);
        this.ciphertext = GetCiphertext(this.plaintextSegments);
        this.normalizedCiphertext = DoNormalizeCiphertext(this.plaintextSegments);
    }

    public string Ciphertext()
    {
        return this.ciphertext;
    }

    public IEnumerable<string> PlaintextSegments()
    {
        return this.plaintextSegments;
    }

    public string NormalizeCiphertext()
    {
        return this.normalizedCiphertext;
    }


    private string DoNormalizeCiphertext(IEnumerable<string> plaintextSegments)
    {
        var normalized = new List<string>();
        var maximum = plaintextSegments.ElementAt(0).Count();

        for (var i = 0; i < maximum; i++)
        {
            var current = string.Empty;
            foreach (var segment in plaintextSegments)
            {
                current += (i < segment.Length) ? segment[i].ToString() : string.Empty;
            }

            normalized.Add(current);
        }

        return string.Join(" ", normalized);
    }

    private string GetCiphertext(IEnumerable<string> plaintextSegments)
    {
        var cipher = new string[plaintextSegments.ElementAt(0).Length];

        for (var i = 0; i < plaintextSegments.Count(); i++)
        {
            var current = 0;
            foreach (var character in plaintextSegments.ElementAt(i))
            {
                cipher[current] += character;
                current++;
            }
        }

        return string.Join("", cipher);
    }

    private IEnumerable<string> Chunk(string textToChunk, int size)
    {
        for (var i = 0; i < textToChunk.Length; i += size)
        {
            yield return string.Join("", textToChunk.Skip(i).Take(size));
        }
    }

    private int GetSize(string normalizedPlaintext)
    {
        return (int)Math.Ceiling(Math.Sqrt(normalizedPlaintext.Length));
    }

    private string GetLettersAndDigits(string original)
    {
        return Regex.Replace(original, @"[^A-Za-z0-9]", "");
    }
}
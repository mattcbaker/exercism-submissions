using System;
using System.Linq;

class Cipher
{
    public string Key { get; }

    public Cipher()
    {
        Key = GenerateKey();
    }

    public Cipher(string key)
    {
        if (key.Any(c => c.ToString() == c.ToString().ToUpper()) || string.IsNullOrWhiteSpace(key))
        {
            throw new ArgumentException();
        }

        Key = key;
    }

    public string Encode(string plaintext)
    {
        var buffer = plaintext.ToCharArray();

        for (var i = 0; i < buffer.Length; i++)
        {
            var shifted = (Key[i] - 'a') + buffer[i];
            buffer[i] = NormalizeShifted((char)shifted);
        }

        return string.Join("", buffer);
    }

    public string Decode(string cipher)
    {
        var buffer = cipher.ToCharArray();

        for (var i = 0; i < buffer.Length; i++)
        {
            var shifted = buffer[i] - (Key[i] - 'a');
            buffer[i] = NormalizeShifted((char)shifted);
        }

        return string.Join("", buffer);
    }

    private char NormalizeShifted(char shifted)
    {
        if (shifted > 'z')
        {
            shifted -= (char)26;
        }

        if (shifted < 'a')
        {
            shifted += (char)26;
        }

        return shifted;
    }

    string GenerateKey()
    {
        var random = new Random((int)DateTime.Now.Ticks);
        var key = new int[100].Select(_ => (char)('a' + random.Next(0, 26)));

        return string.Concat(key);
    }
}
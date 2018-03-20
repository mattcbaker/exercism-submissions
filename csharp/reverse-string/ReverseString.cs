public static class ReverseString
{
    public static string Reverse(string input)
    {
        var reversed = string.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        return reversed;
    }
}
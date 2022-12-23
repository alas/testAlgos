namespace ConsoleApp1;

//3- Desarrollar un 3er algoritmo a elección, utilizando LINQ y recursividad.
internal class AlgoFreeStyle : ISecurityElement
{
    public string Decrypt(string text)
    {
        var decryptedParts = text.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(x => DecryptPart(x));
        return String.Join(string.Empty, decryptedParts);
    }

    private string DecryptPart(string textPart)
    {
        var parts = textPart.Split('=');
        var repeatedChar = Enumerable.Repeat(parts[1], Convert.ToInt32(parts[0]));
        return String.Join(string.Empty, repeatedChar);
    }

    public string Encrypt(string text)
    {
        return EncryptPart(text);
    }

    private string EncryptPart(ReadOnlySpan<char> text, int index = 0)
    {
        if (index >= text.Length) return string.Empty;

        var count = 1;
        var currentLetter = text[index++];
        while (index < text.Length && currentLetter == text[index])
        {
            index++;
            count++;
        }

        return count.ToString() + "=" + currentLetter.ToString() + ";" + EncryptPart(text, index);
    }
}

namespace ConsoleApp1;

//1- Deberá invertir el orden de los caracteres de la cadena.
internal class AlgoInvert : ISecurityElement
{
    private static string Implementation(string text)
    {
        return text.Select(x => x).Reverse().ToString();
    }
    public string Decrypt(string text)
    {
        return Implementation(text);
    }

    public string Encrypt(string text)
    {
        return Implementation(text);
    }
}

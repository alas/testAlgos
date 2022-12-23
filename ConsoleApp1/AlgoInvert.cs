namespace ConsoleApp1;

//1- Deberá invertir el orden de los caracteres de la cadena.
internal class AlgoInvert : ISecurityElement
{
    private static string Implementation(string text)
    {
        return new string(text.Reverse().ToArray());
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

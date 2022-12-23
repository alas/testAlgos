namespace ConsoleApp1;

//2- Realizar un reemplazo de cada letra en base a dos funciones recibidas como parámetros
//(una para encriptar y otra para desencriptar), que se recibe al construir el algoritmo.
//La función recibirá el código ASCII de carácter y le aplicará una cuenta matemática para obtener
//un nuevo carácter dentro de los caracteres válidos.
internal class AlgoReplace : ISecurityElement
{
    private Func<char, char> EncryptFunc { get; set; }
    private Func<char, char> DecryptFunc { get; set; }

    public AlgoReplace(Func<char, char> encrypt, Func<char, char> decrypt)
    {
        EncryptFunc = encrypt;
        DecryptFunc = decrypt;
    }

    public string Decrypt(string text)
    {
        return String.Join(string.Empty, text.Select(x => DecryptFunc(x)));
    }

    public string Encrypt(string text)
    {
        return String.Join(string.Empty, text.Select(x => EncryptFunc(x)));
    }
}

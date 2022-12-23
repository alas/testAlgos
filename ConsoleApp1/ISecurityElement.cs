namespace ConsoleApp1;

internal interface ISecurityElement
{
    string Encrypt(string text);
    string Decrypt(string text);
}

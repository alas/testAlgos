using ConsoleApp1;

//var path = @"C:\visual studio 2012\Projects\ConsoleApplication1\ConsoleApplication1\DLL.dll";
//var className = "DLL.Class1";
//dynamic assembly = DllLoader.LoadDll(path, className);
//List<String> theOrders = assembly.GetOrders();

var theOrders = new List<string>()
{
    "AlgoInvert",
    "AlgoReplace",
    "AlgoFreeStyle",
    "AlgoInvert",
};
var encryptDecryptClass = new EncryptoDecryptFuncs.Class1();

var algoInvert = new AlgoInvert();
var algoReplace = new AlgoReplace(encryptDecryptClass.Encrypt, encryptDecryptClass.Decrypt);
var algoFreeStyle = new AlgoFreeStyle();

Console.WriteLine("Please input a string:");
string input = "jajaAAAmarDECobos";//Console.ReadLine();

String temp = input;
foreach (var algo in theOrders)
{
    switch (algo)
    {
        case "AlgoInvert":
            temp = algoInvert.Encrypt(temp);
            break;
        case "AlgoReplace":
            temp = algoReplace.Encrypt(temp);
            break;
        case "AlgoFreeStyle":
            temp = algoFreeStyle.Encrypt(temp);
            break;
        default:
            throw new NotImplementedException($"Algorithm not implemented: {algo}");
    }
}
var encrypted = temp;

theOrders.Reverse();
foreach (var algo in theOrders)
{
    switch (algo)
    {
        case "AlgoInvert":
            temp = algoInvert.Decrypt(temp);
            break;
        case "AlgoReplace":
            temp = algoReplace.Decrypt(temp);
            break;
        case "AlgoFreeStyle":
            temp = algoFreeStyle.Decrypt(temp);
            break;
        default:
            throw new NotImplementedException($"Algorithm not implemented: {algo}");
    }
}
var decrypted = temp;

Console.WriteLine($"The initial string: {input}");
Console.WriteLine($"The resulting encrypted string: {encrypted}");
Console.WriteLine($"The resulting decrypted string: {decrypted}");
Console.WriteLine($"The resulting decrypted string is {(input == decrypted ? "" : "NOT!!! ")}the same as the initial string!");
Console.ReadLine();



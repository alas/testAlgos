namespace ConsoleApp1;

using System.Reflection;

internal static class DllLoader
{
    internal static object? LoadDll(string path, string className)
    {
        var DLL = Assembly.LoadFile(path);

        var class1Type = DLL.GetType(className);
        return Activator.CreateInstance(class1Type);
    }
}

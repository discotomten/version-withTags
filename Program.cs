using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

if (args[0] == "-v" || (args[0] == "--version"))
{
    var asem = Assembly.GetExecutingAssembly();
    var version = asem?.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;

    System.Console.WriteLine(version ?? "unknown");
}
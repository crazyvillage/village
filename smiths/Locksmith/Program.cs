using System.Security.Cryptography;
using System.Text;

namespace Locksmith;

internal static class Program
{
    public static void Main(string[] args)
    {
        var key = args[0];
        using var sha1 = SHA1.Create();
        var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(key));
        Console.WriteLine(Convert.ToHexString(hash).ToLowerInvariant()[..31]);
    }
}
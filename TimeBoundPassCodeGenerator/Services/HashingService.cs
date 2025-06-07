using System.Security.Cryptography;
using System.Text;

namespace TimeBoundPassCodeGenerator.Services;

public static class HashingService
{
    public static int HashMobileNumber(string mobile)
    {
        using var sha512 = SHA512.Create();
        var hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(mobile));
        return Math.Abs(BitConverter.ToInt32(hash, 0));
    }

    public static int HashPassCode(string input)
    {
        using var sha384 = SHA384.Create();
        var hash = sha384.ComputeHash(Encoding.UTF32.GetBytes(input));
        return Math.Abs(BitConverter.ToInt32(hash, 0));
    }
}

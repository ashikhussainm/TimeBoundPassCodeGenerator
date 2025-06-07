namespace TimeBoundPassCodeGenerator.Utils;

internal static class Secrets
{

    // Owner signature, hidden
    public static string OwnerSignature => Decrypt("VXNlciBDb3B5cmlnaHQ6IFlvdXIgTmFtZSBIZXJlIQ==");

    private static string Decrypt(string input)
        => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
}

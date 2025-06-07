namespace TimeBoundPassCodeGenerator.Services;

public static class PassCodeGenerator
{
    public static bool IsValidMobileNumber(string? mobile)
        => !string.IsNullOrWhiteSpace(mobile) && mobile.Length == 10 && mobile.All(char.IsDigit);

    public static int Generate(string mobileNumber)
    {
        var epochSeconds = TimeService.GetNext30MinuteEpoch();
        var hashedMobile = HashingService.HashMobileNumber(mobileNumber);
        var xorResult = epochSeconds ^ hashedMobile;
        return HashingService.HashPassCode(xorResult.ToString());
    }
}

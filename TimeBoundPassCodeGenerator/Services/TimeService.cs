namespace TimeBoundPassCodeGenerator.Services;

public static class TimeService
{
    public static int GetNext30MinuteEpoch()
    {
        var now = DateTime.UtcNow;
        var adjusted = now.Minute > 30
            ? new DateTime(now.Year, now.Month, now.Day, now.Hour + 1, 0, 0)
            : new DateTime(now.Year, now.Month, now.Day, now.Hour, 30, 0);

        return (int)(adjusted - new DateTime(1970, 1, 1)).TotalSeconds;
    }
}

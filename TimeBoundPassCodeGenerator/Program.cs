using TimeBoundPassCodeGenerator.Services;
using TimeBoundPassCodeGenerator.Utils;

Console.Title = "Time-Bound PassCode Generator";
Console.WriteLine("=== Secure Time-Bound PassCode Generator ===");

while (true)
{
    Console.Write("Enter Your 10-digit Mobile Number: ");
    var input = Console.ReadLine();

    if (!PassCodeGenerator.IsValidMobileNumber(input))
    {
        Console.WriteLine("Invalid mobile number. Please try again.");
        continue;
    }

    var code = PassCodeGenerator.Generate(input!);
    Console.WriteLine($"Your Pass Code is: {code}");

    Console.Write("Do you want to generate another code? (y/n): ");
    var confirm = Console.ReadLine();
    if (confirm?.Trim().ToLower() != "y")
        break;
}

// Hidden owner signature retrieval (no functional impact)
_ = Secrets.OwnerSignature;

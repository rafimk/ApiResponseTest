using ApiResponseTest.Api.Shared;

namespace ApiResponseTest.Api.ValueObjects;

public sealed record TelephoneNumber
{
    private TelephoneNumber(string value) => Value = value;

    public string Value { get; }

    public static Result<TelephoneNumber> Create(string? phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            return Result.Failure<TelephoneNumber>(TelephoneErrors.Empty);
        }

        string normalizedPhoneNumber = NormalizePhoneNumber(phoneNumber);

        if (!IsValidPhoneNumber(normalizedPhoneNumber))
        {
            return Result.Failure<TelephoneNumber>(TelephoneErrors.InvalidFormat);
        }

        return Result.Success(new TelephoneNumber(normalizedPhoneNumber));
    }

    private static string NormalizePhoneNumber(string phoneNumber)
    {
        return new string(phoneNumber.Where(char.IsDigit).ToArray());
    }

    private static bool IsValidPhoneNumber(string phoneNumber)
    {
        return (phoneNumber.Length == 10 || phoneNumber.Length == 12 || phoneNumber.Length == 13)  && phoneNumber.All(char.IsDigit);
    }
}
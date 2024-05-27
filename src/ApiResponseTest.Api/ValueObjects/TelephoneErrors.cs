using ApiResponseTest.Api.Shared;

namespace ApiResponseTest.Api.ValueObjects;

public static class TelephoneErrors
{
    public static readonly Error Empty = Error.Problem("Email.Empty", "Phone number cannot be empty.");

    public static readonly Error InvalidFormat = Error.Problem("Email.InvalidFormat", "Invalid phone number format.");
}
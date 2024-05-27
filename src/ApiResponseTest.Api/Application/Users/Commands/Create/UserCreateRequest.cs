namespace ApiResponseTest.Api.Application.Users.Commands.Create;

public sealed record UserCreateRequest(string FullName, string Email, string PhoneNumber, string Password, string ConfirmPassword);
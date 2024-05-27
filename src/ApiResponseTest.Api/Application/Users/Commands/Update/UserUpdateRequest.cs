namespace ApiResponseTest.Api.Application.Users.Commands.Update;

public sealed record UserUpdateRequest(Guid UserId, string FullName, string Email, string PhoneNumber);
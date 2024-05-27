namespace ApiResponseTest.Api.Application.Users.Queries.GetUserById;

public record UserResponse(Guid Id, string FullName, string Email, string PhoneNumber);

public record UserDetailsResponse(Guid Id, string FullName, string Email, string PhoneNumber, string Password);
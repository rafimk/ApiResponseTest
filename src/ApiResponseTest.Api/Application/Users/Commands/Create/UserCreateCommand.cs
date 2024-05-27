using ApiResponseTest.Api.Abstractions.Messaging;

namespace ApiResponseTest.Api.Application.Users.Commands.Create;

public sealed record UserCreateCommand(string FullName, string Email, string PhoneNumber, string Password, string ConfirmPassword) : ICommand<Guid>;
using ApiResponseTest.Api.Abstractions.Messaging;

namespace ApiResponseTest.Api.Application.Users.Commands.Update;

public sealed record UserUpdateCommand(Guid UserId, string FullName, string Email, string PhoneNumber) : ICommand;
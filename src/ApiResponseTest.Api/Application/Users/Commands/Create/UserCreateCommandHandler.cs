using ApiResponseTest.Api.Abstractions.Messaging;
using ApiResponseTest.Api.Shared;
using ApiResponseTest.Api.ValueObjects;

namespace ApiResponseTest.Api.Application.Users.Commands.Create;

internal sealed class UserCreateCommandHandler() : ICommandHandler<UserCreateCommand, Guid>
{
    public async Task<Result<Guid>> Handle(
        UserCreateCommand command,
        CancellationToken cancellationToken)
    {
        Result<TelephoneNumber> phoneNumberResult = TelephoneNumber.Create(command.PhoneNumber);

        if (phoneNumberResult.IsFailure)
        {
            return Result.Failure<Guid>(phoneNumberResult.Error);
        }

        await Task.CompletedTask;

        return Guid.NewGuid();
    }
}
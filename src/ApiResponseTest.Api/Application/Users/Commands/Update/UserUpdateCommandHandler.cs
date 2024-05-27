using ApiResponseTest.Api.Abstractions.Messaging;
using ApiResponseTest.Api.Shared;
using ApiResponseTest.Api.ValueObjects;

namespace ApiResponseTest.Api.Application.Users.Commands.Update;

internal sealed class UserUpdateCommandHandler() : ICommandHandler<UserUpdateCommand>
{
    public async Task<Result> Handle(
        UserUpdateCommand command,
        CancellationToken cancellationToken)
    {
        Result<TelephoneNumber> phoneNumberResult = TelephoneNumber.Create(command.PhoneNumber);

        if (phoneNumberResult.IsFailure)
        {
            return Result.Failure<Guid>(phoneNumberResult.Error);
        }

        await Task.CompletedTask;

        return Result.Success();
    }
}
using ApiResponseTest.Api.Abstractions.Messaging;
using ApiResponseTest.Api.Shared;

namespace ApiResponseTest.Api.Application.Users.Queries.GetUserById;

internal sealed class GetMemberIdQueryHandler()
    : IQueryHandler<GetMemberIdQuery, UserResponse>
{
    public async Task<Result<UserResponse>> Handle(
        GetMemberIdQuery query,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return new UserResponse(Guid.NewGuid(), "Full Name", "email@email.com", "+971554296326");
    }
}
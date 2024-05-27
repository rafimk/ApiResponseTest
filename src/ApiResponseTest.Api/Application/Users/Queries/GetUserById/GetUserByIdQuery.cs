using ApiResponseTest.Api.Abstractions.Messaging;

namespace ApiResponseTest.Api.Application.Users.Queries.GetUserById;

public sealed record GetMemberIdQuery(Guid MemberId) : IQuery<UserResponse>;
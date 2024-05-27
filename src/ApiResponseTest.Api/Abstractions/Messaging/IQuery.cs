using MediatR;
using ApiResponseTest.Api.Shared;

namespace ApiResponseTest.Api.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
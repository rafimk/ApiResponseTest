using MediatR;
using ApiResponseTest.Api.Shared;

namespace ApiResponseTest.Api.Abstractions.Messaging;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
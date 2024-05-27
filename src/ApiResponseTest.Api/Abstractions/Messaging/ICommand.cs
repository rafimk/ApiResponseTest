using MediatR;
using ApiResponseTest.Api.Shared;

namespace ApiResponseTest.Api.Abstractions.Messaging;


public interface ICommand : IRequest<Result>, IBaseCommand
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{
}

public interface IBaseCommand
{
}
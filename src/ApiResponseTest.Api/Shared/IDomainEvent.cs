using MediatR;

namespace ApiResponseTest.Api.Shared;

public interface IDomainEvent : INotification
{
    Guid Id { get; }

    DateTime OccurredOnUtc { get; }
}
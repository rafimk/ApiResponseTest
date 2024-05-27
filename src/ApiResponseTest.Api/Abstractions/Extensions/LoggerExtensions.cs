using Microsoft.Extensions.Logging;
using ApiResponseTest.Api.Shared;

namespace ApiResponseTest.Api.Abstractions.Extensions;

public static class LoggerExtensions
{
    public static void LogError(this ILogger logger, IDomainEvent domainEvent, Error error) =>
        logger.LogError("Error while processing domain event: {DomainEventId} - {Error}", domainEvent.Id, error);
}
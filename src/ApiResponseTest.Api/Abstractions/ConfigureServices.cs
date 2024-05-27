using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using ApiResponseTest.Api.Abstractions.Abstractions.Behaviors;

namespace ApiResponseTest.Api.Abstractions;

public static class ConfigureServices
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(typeof(ConfigureServices).Assembly);

            config.AddOpenBehavior(typeof(RequestLoggingPipelineBehavior<,>));
            config.AddOpenBehavior(typeof(ValidationPipelineBehavior<,>));
            config.AddOpenBehavior(typeof(QueryCachingPipelineBehavior<,>));
        });

        services.AddValidatorsFromAssembly(
            typeof(ConfigureServices).Assembly,
            includeInternalTypes: true);

        return services;
    }
}
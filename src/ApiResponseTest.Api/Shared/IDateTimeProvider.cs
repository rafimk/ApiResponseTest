namespace ApiResponseTest.Api.Shared;

public interface IDateTimeProvider
{
    public DateTime UtcNow { get; }
}
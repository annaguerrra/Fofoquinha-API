namespace Fofoquinha_API;

public record Result<T>(
    T Data,
    bool IsSuccess,
    string Reason
)
{
    public static Result<T> Ok(T data)
        => new(data, true, null);

    public static Result<T> BadRequest(T data, string reason)
        => new(data, false, reason);
}
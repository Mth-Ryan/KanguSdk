using System.Text.Json.Serialization;

namespace Kangu.Sdk;

public class KanguInnerError
{
    [JsonPropertyName("codigo")]
    public required uint Codigo { get; set; }
    [JsonPropertyName("mensagem")]
    public required string Mensagem { get; set; }
}

public class KanguRequestError
{
    [JsonPropertyName("error")]
    public required KanguInnerError Error { get; set; }
}

public sealed class KanguResult<T>
{
    public required T? Value { get; init; }
    public required  KanguRequestError? Error { get; init; }

    public bool IsError() => Error is not null;

    public static KanguResult<T> Ok(T input) =>
        new KanguResult<T>
        {
            Value = input,
            Error = null
        };

    public static KanguResult<T> Err(KanguRequestError err) =>
        new KanguResult<T>
        {
            Value = default(T),
            Error = err
        };
}

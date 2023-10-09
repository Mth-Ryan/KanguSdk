using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguError
{
    [JsonPropertyName("codigo")]
    public required uint Codigo { get; set; }
    [JsonPropertyName("mensagem")]
    public required uint Mensagem { get; set; }
}

public abstract class KanguOutput
{
    public KanguError? error { get; set; }
}

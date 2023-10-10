using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguError
{
    [JsonPropertyName("codigo")]
    public required string Codigo { get; set; }
    [JsonPropertyName("mensagem")]
    public required string Mensagem { get; set; }
}

public abstract class KanguOutput
{
    [JsonPropertyName("error")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public KanguError? Error { get; set; }
}

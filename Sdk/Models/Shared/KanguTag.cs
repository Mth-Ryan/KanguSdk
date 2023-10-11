using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguTag
{
    [JsonPropertyName("numero")]
    public required string Numero { get; set; }

    [JsonPropertyName("numeroTransp")]
    public required string NumeroTransp { get; set; }

    [JsonPropertyName("pdf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Pdf { get; set; }

    // Inconsistente entre respostas
    /* [JsonPropertyName("volume")] */
    /* public required KanguVolumeWithItems Volume { get; set; } */
}

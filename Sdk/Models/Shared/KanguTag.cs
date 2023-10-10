using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguTag
{
    [JsonPropertyName("numero")]
    public required string Numero { get; set; }

    [JsonPropertyName("numeroTransp")]
    public required string NumeroTransp { get; set; }

    [JsonPropertyName("pdf")]
    public required string pdf { get; set; }

    [JsonPropertyName("volumes")]
    public required KanguVolumeWithItems Volumes { get; set; }
}
